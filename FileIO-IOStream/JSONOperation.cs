using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
namespace FileIO_IOStream
{
    class JSONOperation
    {
        /* JSON (JavaScript Object Notation) is a lightweight data-interchange format. 
           It is easy for humans to read and write and easy for machines to parse and generate. 
           JSON is a text format that is completely language independent.
         */

        public static void JSONSerialization()
        {
            try
            {
                string path = @"D:\Practice\C#\FileIO-IOStream\FileIO-IOStream\Files Operation\JSONSerialization.json"; //Set path to create file
                Details details = new Details() //crtate object of Contact Class and initilize data
                { FirstName = "Omprakash", LastName = "Khawshi", Address = "Alandi", City = "Pune", Pin = "412105", Number = "8788616249" }; //initilize data

                string result = JsonConvert.SerializeObject(details); //convert Details object to JSON String Formatt and store result veriable
                File.WriteAllText(path, result);
                Console.WriteLine($"File Successfully Created JSONSerialization.json And Serialize Content"); //Print msg

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        public static void JSONDesrialization()
        {
            try
            {
                string path = @"D:\Practice\C#\FileIO-IOStream\FileIO-IOStream\Files Operation\JSONSerialization.json"; //Set path to create file
                
                string result = File.ReadAllText(path); //read file and store test result
                Details details1 = JsonConvert.DeserializeObject<Details>(result); //DeserializeObject of Details

                Console.WriteLine($"File Successfully Deserialization"); //Print msg
                Console.WriteLine($"FirstName:- {details1.FirstName}\nLastName:- {details1.LastName}\nAddress:- {details1.Address}\nCity:- {details1.City}\nPin:- {details1.Pin}\nNumber:- {details1.Number}");

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

    }
    public class Details
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pin { get; set; }
        public string Number { get; set; }
    }

}
