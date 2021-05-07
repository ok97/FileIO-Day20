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
                    byte[] info = new UTF8Encoding(true).GetBytes("Hello world\nchange world through coding"); // Adding information to the created file.

                    filestream.Write(info, 0, info.Length);
                }
                Console.WriteLine($"File Successfully Created This Location\n{path}"); //rint msg
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        public static void CheckFileExixt()
        {/* 2:- The File exists method is used to check if a particular file exists. 
                So now let's see the code which can be used to check if our .txt file exists or not.
          */
            string path = @"D:\Practice\C#\FileIO-IOStream\FileIO-IOStream\Files Operation\Om.txt"; //Set file Location/ Path
            try
            {
                if (File.Exists(path)) //Check file exixt or not using Exist method
                {
                    Console.WriteLine("File Exist"); //print
                }
                else
                {
                    Console.WriteLine("File Not Exist"); //print
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        /* 3:- The method is used to read all the lines one by one in a file. 
               The lines are then stored in a string array variable
        */
        public static void ReadFileLine()
        {
            try
            {
                string path = @"D:\Practice\C#\FileIO-IOStream\FileIO-IOStream\Files Operation\Om.txt"; //Set file Location/ Path  
                if (File.Exists(path))
                {
                   
                    //using (StreamReader sr = File.OpenText(path)) //method reads a line of characters from the current stream and returns the data as a string. 
                    //{
                    //    string s = "";
                    //    while ((s = sr.ReadLine()) != null)
                    //    {
                    //        Console.WriteLine(s);
                    //    }
                    //}

                    string[] Content = File.ReadAllLines(path);

                    foreach (string line in Content) //iterate content
                    {
                        Console.WriteLine(line); //print content

                    }
                }
                else
                {
                    Console.WriteLine("File Not Exist");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }

    }
}
