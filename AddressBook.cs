﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProject10FebAssgn
{
    internal class AddressBook
    {

        // UC1 Adding Records
        #region uc1 Adding records to list
        public static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork,NY", 15));
            listPersonInCity.Add(new Person("203456877", "SAM", "13 Main Ct, Newyork,NY", 17));
            listPersonInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork,NY", 35));
            listPersonInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork,NY", 45));
            listPersonInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton,OH", 55));
            listPersonInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456882", "Winston", "1208 Alex st, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltimore,NY", 85));
            listPersonInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltimore,NY", 95));
             Console.WriteLine(listPersonInCity.ToString());
            listPersonInCity.ForEach(x => Console.WriteLine("{0}\t",x.Name.ToString()));
        }
        #endregion

        //UC2 to add person name using console
        #region UC2 to add person Name
        public static void AddPerson(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person());
            listPersonInCity.ForEach(x => Console.WriteLine("{0}\t", x.Name.ToString()));
        }
        #endregion

        //UC3 Editing Contacts using Console
        #region UC3 Editing Contacts using console
        public static Person find(string Name)
        {
            List<Person> listPersonInCity;
            listPersonInCity = new List<Person>();
            AddRecords(listPersonInCity);

            Person p = listPersonInCity.Find((e) => e.Name == Name);
            if (p != null)
            {
                Console.WriteLine("Name Found");
                Console.WriteLine("Edit this deatils:");
                Console.WriteLine("SSN :");
                string SSN = Console.ReadLine();
                Console.WriteLine("Address :");
                string Address = Console.ReadLine();
                Console.WriteLine("Age:");
                int Age = Int32.Parse(Console.ReadLine());
                listPersonInCity.ForEach(x => Console.WriteLine("{0}\t{1}\t{2}\t{3}\t", x.Name.ToString(), x.SSN.ToString(), x.Address.ToString(), x.Age.ToString())); ;

            }
            else
            {
                Console.WriteLine("no record found for "+Name);

            }
            return p;
        }
        public static void edit(List<Person> listPersonInCity)

        {
            Console.WriteLine("enter name to edit");
            string Name = Console.ReadLine();
            AddressBook.find(Name);
        }
        #endregion
    }
}
