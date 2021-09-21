using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiIniUI
{
    static class Program
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            string FirstTime = "0";
            try
            {
                using (FileStream fileStream = new FileStream("Settings.txt", FileMode.Open)) // Saving Settings
                {
                    using (StreamReader streamWriter = new StreamReader(fileStream))
                    {
                        FirstTime = streamWriter.ReadLine();
                    }
                }
            }
            catch(Exception e)
            {

            }

            if(FirstTime == "0")
            {
                Application.Run(new Settings());
            }
            else
            {
                Application.Run(new Form1());
            }
                    
        }
    }
}
