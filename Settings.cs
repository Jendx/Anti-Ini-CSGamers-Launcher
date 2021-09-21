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
    public partial class Settings : Form
    {
        private string path = @"C:\";
        private string pathToSteamFolder = @"C:\Program Files (x86)\Steam";
        private string PathToSteamappsFolder;
        private bool IsSteamPlayer = false;

        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindSteam();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            using (FileStream fileStream = new FileStream("Settings.txt", FileMode.OpenOrCreate)) // Saving Settings
            {
                using(StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.WriteLine("1");
                    streamWriter.WriteLine(IsSteamPlayer);
                    streamWriter.WriteLine(pathToSteamFolder);
                    if(IsSteamPlayer)
                    {
                        streamWriter.WriteLine(PathToSteamappsFolder);
                    }
                    
                }
            }

            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }


        private void comboBoxEpicSteam_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxEpicSteam.SelectedIndex == 1)
            {
                textBox1.Visible = true;
                button1.Visible = true;

                IsSteamPlayer = true;
                
                labelSteamPath.Visible = true; // Show Steam settings
                label2.Visible = false; // Hides Epic Settings

            }
            else if(comboBoxEpicSteam.SelectedIndex == 2)
            {
                textBox1.Visible = true;
                button1.Visible = true;

                IsSteamPlayer = false;

                labelSteamPath.Visible = false; // Hide Steam settings
                label2.Visible = true; //Shows Epic Settings
            }


            

            bool FoundIni = true;
            while (FoundIni)// Looking for ARK Installation
            {
                
                string UserIni = "";
                if (IsSteamPlayer)
                {
                    FindSteam();

                    if (File.Exists(pathToSteamFolder + @"\steamapps\common\ARK\Engine\Config\ConsoleVariables.ini"))
                    {
                        UserIni = System.IO.File.ReadAllText(pathToSteamFolder + @"\steamapps\common\ARK\Engine\Config\ConsoleVariables.ini");
                    }
                    else // If ARK is not installed in steam 
                    {
                        if (File.Exists(pathToSteamFolder + @"\steamapps\libraryfolders.vdf")) // We check if Ark is installed in other directory
                        {
                            var SteamLibraryes = System.IO.File.ReadAllLines(pathToSteamFolder + @"\steamapps\libraryfolders.vdf");

                            for(int i = 4; i < SteamLibraryes.Length-1; i++)// Looking trough all directories
                            {
                                var paths = SteamLibraryes[i].Split('"');
                                PathToSteamappsFolder = Path.GetFullPath(paths[3]);

                                if (File.Exists(PathToSteamappsFolder + @"\steamapps\common\ARK\Engine\Config\ConsoleVariables.ini"))// If ark is installed in Paths[3] then we check Inis
                                {
                                    UserIni = System.IO.File.ReadAllText(PathToSteamappsFolder + @"\steamapps\common\ARK\Engine\Config\ConsoleVariables.ini"); 
                                    FoundIni = false;
                                }

                            }
                        }

                        MessageBox.Show($"You don't have ARK installed in \"{pathToSteamFolder}\" folder. \n Select \"ARK\" folder (THE FOLDER MADE BY STEAM)");
                    }
                }
                else
                {
                    if (File.Exists(pathToSteamFolder + @"\Engine\Config\ConsoleVariables.ini"))
                    {
                        UserIni = System.IO.File.ReadAllText(pathToSteamFolder + @"\Engine\Config\ConsoleVariables.ini");
                    }
                    else
                    {
                        MessageBox.Show($"You don't have ARK installed in \"{pathToSteamFolder}\" folder. \n Select \"ARKSurvivalEvolved\" folder (FOLDER CREATED BY EPIC)");
                    }

                }

                //CommonOpenFileDialog d = new CommonOpenFileDialog();
                //d.InitialDirectory = path;
                //d.IsFolderPicker = true;
                //d.ShowDialog();
                //PathToSteamappsFolder = Path.GetFullPath(d.FileName);


                if (File.Exists(PathToSteamappsFolder + @"\ARK\Engine\Config\ConsoleVariables.ini") ||
                    File.Exists(pathToSteamFolder + @"\Engine\Config\ConsoleVariables.ini"))
                {
                    FoundIni = false;
                }
            }
        }


        private void FindSteam()
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog(); // Open's Win10 File Opener
            dialog.InitialDirectory = path;
            dialog.IsFolderPicker = true;

            while (!File.Exists(pathToSteamFolder + "\\steam.exe"))
            {
                MessageBox.Show("Could not find steam folder in c:\\Program Files (x86)\\ \n Select steam folder");

                dialog.ShowDialog();
                pathToSteamFolder = Path.GetFullPath(dialog.FileName); // Get's the path
                this.textBox1.Text = dialog.FileName;
            }

        }
    }
}
