using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_IOStream
{
    class CSVOperation
    {
        

        public static void CSVWriteOperation()
        {
            try
            {
                string path = @"D:\Practice\C#\FileIO-IOStream\FileIO-IOStream\Files Operation\CSVData.csv"; //Set path to create file
                string Destination = @"D:\Practice\C#\FileIO-IOStream\FileIO-IOStream\Files Operation\CopyCSVData.csv"; //Set path to create file                                                                                                                                                                                                          
                var reader = new StreamReader(path);
                var csvRead = new CsvReader(reader, CultureInfo.InvariantCulture); //csv reader
                
                var personDetails = csvRead.GetRecords<SetDetails>().ToList();//Generic method Read all record using getRecord method
                                   
               
                using (var writer = new StreamWriter(Destination)) 
               
                    using (var csvWtiter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                { 
                        csvWtiter.WriteRecords(personDetails);
                }
                Console.WriteLine($"Successfully Write Content Thise location \n{Destination}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        public static void CSVReadOperation()
        {
            try
            {
                string path = @"D:\Practice\C#\FileIO-IOStream\FileIO-IOStream\Files Operation\CSVData.csv"; //Set path to create file
                                                                                                             // FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
                var reader = new StreamReader(path);
                var csvRead = new CsvReader(reader, CultureInfo.InvariantCulture); //csv reader
                var personDetails = csvRead.GetRecords<SetDetails>().ToList();//Generic method Read all record using getRecord method
                foreach (SetDetails item in personDetails)
                {
                    Console.WriteLine($"name:- {item.name} email:- {item.email} phone:- {item.phone} country:- {item.country}");
                }
                Console.WriteLine($"File Successfully Read Content"); //Print msg
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public class SetDetails
        {
            public string name { get; set; } 
            public string email { get; set; }
            public string phone { get; set; } 
            public string country { get; set; }
        }

    }
}

