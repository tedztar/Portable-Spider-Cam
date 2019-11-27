using System;
using System.Collections.Generic;
using System.IO;

namespace PortableSpiderCam
{
    class FileHandlerObject
    {
        // Properties.
        private List<ConfigObject> list_Of_Files = new List<ConfigObject>();

        // Constructors.
        public FileHandlerObject()
        {
            this.list_Of_Files = new List<ConfigObject>();
        }

        public void create_File(string file_Name)
        {
            StreamWriter File = new StreamWriter(file_Name);

            List<int> default_Config = new List<int>() { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            foreach (int value in default_Config)
            {
                File.WriteLine(value);
            }

            this.list_Of_Files.Add(new ConfigObject(file_Name, default_Config));

            File.Close();
        }

        // Methods.
        public void add_File(string file_Name)
        {
            if (!File.Exists(file_Name))
            {
                create_File(file_Name);
            }
            else
            {
                StreamReader File = new StreamReader(file_Name);

                List<int> selected_Config = new List<int>();
                string line;

                while ((line = File.ReadLine()) != null)
                {
                    selected_Config.Add(Convert.ToInt32(line));
                }

                this.list_Of_Files.Add(new ConfigObject(file_Name, selected_Config));

                File.Close();
            }
        }

        public int find_File(string file_Name)
        {
            int index = 0;

            foreach (ConfigObject file in this.list_Of_Files)
            {
                if (file.get_File_Name() == file_Name)
                {
                    break;
                }
                else
                {
                    index += 1;
                }
            }

            return index;
        }

        public ConfigObject get_File(int file_Index)
        {
            return this.list_Of_Files[file_Index];
        }

        public List<ConfigObject> get_All_Files()
        {
            return this.list_Of_Files;
        }

        public void export_File(int file_Index)
        {
            ConfigObject File_Config = get_File(file_Index);

            StreamWriter File = new StreamWriter(File_Config.get_File_Name());

            foreach (int value in File_Config.get_Config())
            {
                File.WriteLine(value);
            }

            File.Close();
        }

    }
}
