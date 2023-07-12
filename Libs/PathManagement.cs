using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreManagementApp.Libs
{
   public class PathManagement
    {
        public string subName { get; set; }
        public string fullPath { get; set; }
        public bool isExist { get; set; }

        public PathManagement(string subName)
        {
            this.subName = subName;
            this.createIfNotExist();
        }

        public void createIfNotExist()
        {            
            string[] subNameArray = subName.Split('\\');
            string path = Directory.GetCurrentDirectory();
            foreach (string name in subNameArray)
            {
                path += "\\" + name;

                // check if that path it is a file
                
                if (!File.Exists(path))
                    if (!File.Exists(path) && !Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
            }

            fullPath = path;
            isExist = true;
        }

        public void deleteIfExist()
        {
            if (isExist)
            {
                Directory.Delete(fullPath, true);
                isExist = false;
            }
        }

        public void deleteIfExist(string subName)
        {
            string[] subNameArray = subName.Split('\\');
            string path = Directory.GetCurrentDirectory();
            foreach (string name in subNameArray)
            {
                path += "\\" + name;
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                }
            }
        }

        public void deleteIfExist(string subName, string fileName)
        {
            string[] subNameArray = subName.Split('\\');
            string path = Directory.GetCurrentDirectory();
            foreach (string name in subNameArray)
            {
                path += "\\" + name;
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                }
            }
            path += "\\" + fileName;
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public string findFile(string subName, string fileName)
        {
            string[] subNameArray = subName.Split('\\');
            string path = Directory.GetCurrentDirectory();
            foreach (string name in subNameArray)
            {
                path += "\\" + name;
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                }
            }
            path += "\\" + fileName;
            if (File.Exists(path))
            {
                return path;
            }
            return null;
        }
   }
}
