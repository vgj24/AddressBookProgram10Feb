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
    class Person
    {
        public string SSN;
        public string Name;
        public string Address;
        public int Age;

        public Person()
        {
            Console.WriteLine("enter details :");
            Console.WriteLine("SSN :" + SSN);
            SSN = Console.ReadLine();
            Console.WriteLine("Name" + Name);
            Name = Console.ReadLine();
            Console.WriteLine("address" + Address);
            Address = Console.ReadLine();
            Console.WriteLine("Age" + Age);
            Age = Int32.Parse(Console.ReadLine());
        }
        public Person(string ssn, string name, string addr, int age)
        {
            SSN = ssn;
            Name = name;
            Address = addr;
            Age = age;

            string path = @"C:\Users\vgj24\source\repos\AddressBookProject10FebAssgn\AdressBookTextFile.txt";
            string lines;
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("{0},{1},{2},{3}", SSN, Name, Address, Age);
                sr.Close();
                lines = File.ReadAllText(path);
                Console.WriteLine(lines);

            }
            //string importFilePath = @"C:\Users\vgj24\source\repos\AddressBookProject10FebAssgn\Adressbokkcsv\AddressBookCSV.csv";
            //string exportFilePath = @"C:\Users\vgj24\source\repos\AddressBookProject10FebAssgn\Adressbokkcsv\writeAddressBookCSV.csv";
            //using (var reader = new StreamReader(importFilePath))
            //using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            //{
            //    var records = csv.GetRecords<Person>().ToList();
            //    Console.WriteLine("Read data successfully from Adress Book csv.");
            //    foreach (Person person in records)
            //    {
            //        Console.Write("\t" + SSN);
            //        Console.Write("\t" + Name);
            //        Console.Write("\t" + Address);
            //        Console.Write("\t" + Age);

            //        Console.WriteLine("**********************Reading fromcsv file and Write to csv file **************************");
            //        //Writing json file
            //        JsonSerializer serializer = new JsonSerializer();
            //        using (StreamWriter sw = new StreamWriter(exportFilePath))
            //        using (JsonWriter writer = new JsonTextWriter(sw))
            //        {
            //            serializer.Serialize(writer, records);
            //        }
            //    }

            //}

        }
    }
}
