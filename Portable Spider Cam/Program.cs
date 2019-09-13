using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //CHECK IF FILE EXISTS BEFORE LOADING THE WINDOWS.FORM (GUI.)
            
            //SET THE DATA TO A CONFIGOBJECT
            ConfigObject ConfigFile = new ConfigObject(0, 0, 0, 0, 0, 0, 0, 0, 0);
            // TEST // Console.WriteLine(ConfigFile.GetDrum_Gear());

            //RUN THE WINDOWS.FORM (GUI.)
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
