using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_IOStream
{
    class FileIO
    {
        public static void CreateFile() //Create Method To Create File
        {
            string path = @"D:\Practice\C#\FileIO-IOStream\FileIO-IOStream\Files Operation\Om.txt"; //Set path to create file

            try
            {
                using (FileStream filestream = File.Create(path)) // Create the file or overwrite if the file exists
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("Welcome Omprakash"); // Adding information to the created file.

                    filestream.Write(info, 0, info.Length); 
                }
                Console.WriteLine($"File Successfully Created This Location\n{path}"); //rint msg
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
