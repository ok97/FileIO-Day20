using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_IOStream
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileIO.CreateFile();
            //FileIO.CheckFileExixt();
            //FileIO.ReadFileLine();
            //FileIO.CopyDataFile();
            // FileIO.DeleteFile();
            // FileIO.StreamWriter();
            // FileIO.StreamReader();
            //BinaryOperation.BinarySerialization();
            //BinaryOperation.BinaryDeserialization();
            //JSONOperation.JSONSerialization();
            //JSONOperation.JSONDesrialization();
            // XMLOperation.XMLSerialization();
            //XMLOperation.XMLDeserialization();            
            //CSVOperation.CSVWriteOperation();
            // CSVOperation.CSVReadOperation();
            //ThirdPartyLibraryOperation.CSVToJSON();
            ThirdPartyLibraryOperation.JSONToCSV();

            Console.ReadLine(); //Reading from CSV To Json File and writing Json File
        }
    }
}
