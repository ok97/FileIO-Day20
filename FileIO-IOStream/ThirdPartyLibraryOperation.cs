using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using static FileIO_IOStream.CSVOperation;

namespace FileIO_IOStream
{
    class ThirdPartyLibraryOperation
    {
        public static void CSVToJSON()
        {
            /* Reading from CSV File and writing Json File. 
             */
            try
            {
                string path = @"D:\Practice\C#\FileIO-IOStream\FileIO-IOStream\Files Operation\CSVData.csv"; //Set path to create file
                string Destination = @"D:\Practice\C#\FileIO-IOStream\FileIO-IOStream\Files Operation\CSVToJSON.json"; //Set path to create file                                                                                                                                                                                                          
                if (File.Exists(path)) //Check file exixt or not
                {
                    var reader = new StreamReader(path);//Read Path
                    var csvRead = new CsvReader(reader, CultureInfo.InvariantCulture); //csv reader
                    var personDetails = csvRead.GetRecords<SetDetails>().ToList();//Generic method Read all record using getRecord method
                  
                    JsonSerializer json = new JsonSerializer(); //create object JsonSerializer class

                    using (var writer = new StreamWriter(Destination))
                        using(var jsonWriter = new JsonTextWriter(writer))                         
                    {
                        json.Serialize(jsonWriter, personDetails);
                    }

                    Console.WriteLine($"File Successfully Read CSV File Content and Write JSON File"); //Print msg
                }
                else
                {
                    Console.WriteLine("File Not Exist");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
