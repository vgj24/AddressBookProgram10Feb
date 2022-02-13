using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using Newtonsoft.Json;

namespace AddressBookProject10FebAssgn
{
    class CSVJSON
    {
        public static void ImplemntCSVjSON()
        {
            string importFilePath = @"";
            string exportFilePath = @"C:\Users\vgj24\source\repos\AddressBookProject10FebAssgn\Adressbokkcsv\writeAddressBookCSV.csv";
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Person>().ToList();
                Console.WriteLine("Read data successfully from Adress Book csv.");
                foreach (Person person in records)
                {
                    Console.Write("\t" + person.SSN);
                    Console.Write("\t" + person.Name);
                    Console.Write("\t" + person.Address);
                    Console.Write("\t" + person.Age);
                }
                Console.WriteLine("**********************Reading fromcsv file and Write to csv file **************************");
                //Writing json file
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportFilePath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records);
                }
            }
        }
    }
}
