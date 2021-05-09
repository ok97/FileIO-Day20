using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_IOStream
{
    class BinaryOperation
    { /* Binary Serialization:- Converting an Object to a Binary format which is not in a human readable 
                                format is called Binary Serialization.
         Deserialization:- Converting back the binary format to human readable format is called deserialization.
     */
        public static void BinarySerialization()
        {/* 8:- Binary Serialization: Converting an Object to a Binary format which is not in a human readable 
            format is called Binary Serialization.
            */
            try
            {
                Data data = new Data();
                string path = @"D:\Practice\C#\FileIO-IOStream\FileIO-IOStream\Files Operation\OmSerialization.txt"; //Set path to create file
                BinaryFormatter BinaryS = new BinaryFormatter(); // Create object BinaryFormatter class Serializ provide Serialize method operation use BinaryFormatter class
                FileStream file = new FileStream(path, FileMode.OpenOrCreate);
                BinaryS.Serialize(file, data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
    [Serializable]
    class Data
    {
        public string FirstName { get; set; } = "Omprakash";
        public string NameName { get; set; } = "Khawshi";
        public string Address { get; set; } = "Pune";
        public string City { get; set; } = "Pune";
        public string Pin { get; set; } = "412105";
        public string Number { get; set; } = "8788616249";
    }
}
