using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace PortableSpiderCam
{
    class FileHandlerObject
    {
        // 1. PROPERTIES. (ALLOWS THE CLASS TO RECOGNISE THESE PASSED VARIABLE NAMES.)
        private List<ConfigObject> list_Of_Files = new List<ConfigObject>();

        // 2. CONSTRUCTOR. (ASSIGNS THE VALUES TO ITSELF: THE OBJECT.)
        public FileHandlerObject()
        {
            this.list_Of_Files = new List<ConfigObject>();
        }

        // 3. METHODS. (PROVIDE FUNCTIONS WHICH CAN BE USED THROUGHOUT THE MAIN CODE.)
        public void addFile(string file_Name)
        {

            if (!File.Exists(file_Name))
            {
                using (var file = new StreamWriter(file_Name, true))
                {
                    file.WriteLine("0,0,0,0,0,0,0,0,0");
                }
                this.list_Of_Files.Add(new ConfigObject(file_Name, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            }
            else
            {
                using (var file = new StreamReader(file_Name, true))
                {
                    foreach (string line in File.ReadAllLines(file_Name))
                    {
                        Console.WriteLine(line);
                    }
                }
                this.list_Of_Files.Add(new ConfigObject(file_Name, 0, 0, 0, 0, 0, 0, 0, 0, 0));
            }

        }

    }
}
