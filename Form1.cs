using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace AntiIniUI
{
    public partial class Form1 : Form
    {
        private string pathToSteamFolder;
        private string PathToSteamappsFolder;
        private const string Key = "AVCDK68D12345678A1B2C3D4E5F6G7H8";
        private string DecryptedText = ""; 
        private string path = @"C:\";
        private bool IsSteamPlayer = false;

        public Form1()
        {
            InitializeComponent();

            Load();

            Decrypt();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(IsSteamPlayer)
            //{
            //    CommonOpenFileDialog dialog = new CommonOpenFileDialog(); // Open's Win10 File Opener
            //    dialog.InitialDirectory = path;
            //    dialog.IsFolderPicker = true;
            //    dialog.ShowDialog();

            //    pathToSteamFolder = Path.GetFullPath(dialog.FileName); // Get's the path
            //    this.textBox1.Text = dialog.FileName;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string UserIni = "";
            try // If Steamapps are present in the Steam folder
            {
                if(IsSteamPlayer)
                {
                    UserIni = System.IO.File.ReadAllText(pathToSteamFolder + @"\steamapps\common\ARK\Engine\Config\ConsoleVariables.ini");
                }
                else
                {
                    UserIni = System.IO.File.ReadAllText(pathToSteamFolder + @"\Engine\Config\ConsoleVariables.ini");
                }
                
            }
            catch(Exception exce) // If Steamapps is in different folder
            {

                if (IsSteamPlayer)
                {
                    UserIni = System.IO.File.ReadAllText(PathToSteamappsFolder + @"\common\ARK\Engine\Config\ConsoleVariables.ini");
                }
                else
                {
                    //UserIni = System.IO.File.ReadAllText(PathToSteamappsFolder + @"\Engine\Config\ConsoleVariables.ini");
                }
            }

            if (UserIni != DecryptedText)
            {
                MessageBox.Show("You are a Cheater :(");
            }
            else
            {
                MessageBox.Show("You are not a Cheater");
            }


            /*
             *
             *
             *
             *
             */

            //Properties.Settings.Default.Properties.Add(new System.Configuration.SettingsProperty("Path") {DefaultValue = pathToSteamFolder});
            if (IsSteamPlayer)
            {
                Process Steam = new Process();
                Steam.StartInfo.FileName = pathToSteamFolder + "\\steam.exe";
                Steam.StartInfo.Arguments = "steam://rungameid/346110";
                Steam.Start();
            }
            else
            {
                Process Epic = new Process();
                Epic.StartInfo.FileName = @"com.epicgames.launcher://apps/ark%3A743e47ee84ac49a1a49f4781da70e0d0%3Aaafc587fbf654758802c8e41e4fb3255?action=launch&silent=true"; // Přidat sem ARK odkaz
                Epic.StartInfo.Arguments = "";
                Epic.Start();
            }
        }

        private void Load()
        {
            using (FileStream fileStream = new FileStream("Settings.txt", FileMode.Open)) // Saving Settings
            {
                using (StreamReader streamWriter = new StreamReader(fileStream))
                {
                    streamWriter.ReadLine();
                    IsSteamPlayer = (streamWriter.ReadLine() == "True") ? true : false;

                    pathToSteamFolder = streamWriter.ReadLine();

                    if (IsSteamPlayer)
                    {
                        PathToSteamappsFolder = streamWriter.ReadLine();
                    }
                }
            }
            
        }

        #region Cryption
        public void Encrypt()
        {
            string textToEncrypt = Properties.Settings.Default.DefaultData;
            using (FileStream fileStream = new FileStream("TestData.txt", FileMode.OpenOrCreate))
            {
                using (Aes aes = Aes.Create())
                {
                    byte[] Aeskey = Encoding.UTF8.GetBytes(Key);
                    //aes.GenerateKey();
                    // string k = Encoding.UTF8.GetString( aes.Key);
                    aes.Key = Aeskey;

                    byte[] iv = aes.IV;
                    fileStream.Write(iv, 0, iv.Length);

                    using (CryptoStream cryptoStream = new CryptoStream(
                        fileStream,
                        aes.CreateEncryptor(),
                        CryptoStreamMode.Write))
                    {
                        using (StreamWriter encryptWriter = new StreamWriter(cryptoStream))
                        {
                            encryptWriter.Write(Properties.Settings.Default.DefaultData);

                        }
                    }
                }
            }
        }

        public void Decrypt()
        {
            using (FileStream fileStream = new FileStream("InputData.txt", FileMode.Open))
            {
                using (Aes aes = Aes.Create())
                {
                    byte[] iv = new byte[aes.IV.Length];
                    int numBytesToRead = aes.IV.Length;
                    int numBytesRead = 0;
                    while (numBytesToRead > 0)
                    {
                        int n = fileStream.Read(iv, numBytesRead, numBytesToRead);
                        if (n == 0) break;

                        numBytesRead += n;
                        numBytesToRead -= n;
                    }

                    byte[] key = Encoding.UTF8.GetBytes(Key);

                    using (CryptoStream cryptoStream = new CryptoStream(
                       fileStream,
                       aes.CreateDecryptor(key, iv),
                       CryptoStreamMode.Read))
                    {
                        using (StreamReader decryptReader = new StreamReader(cryptoStream) )
                        {
                            DecryptedText = decryptReader.ReadToEnd();
                            
                        }
                    }
                }
            }
        }
        #endregion

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
