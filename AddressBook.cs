using System;
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
            //Console.WriteLine(listPersonInCity.ToString());
            listPersonInCity.ForEach(x => Console.WriteLine("{0}\t", x.Name.ToString()));
        }
        #endregion

        //UC2 to add person name using console
        #region UC2 to add person Name and UC7 checking for duplicate entry
        public static void AddPerson(List<Person> listPersonInCity)
        {
            Console.WriteLine("Checking for duplicate entry");
            Console.WriteLine("enter name of person");
            string Name = Console.ReadLine();
            if (listPersonInCity.Exists(e => e.Name == Name))
            {
                Console.WriteLine("sorry have an entry for this name already");
            }
            else
            {
                Console.WriteLine("no entry for this name, you can add your details");
                listPersonInCity.Add(new Person());
                Console.WriteLine("Name Added sucessfully");
                listPersonInCity.ForEach(x => Console.WriteLine("{0}\t", x.Name.ToString()));
            }
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
                Console.WriteLine("no record found for " + Name);

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

        //UC4 delete persons name using Console
        #region delete person name using Console
        public static void DeletepersonName(List<Person> listPersonInCity)
        {
            Console.WriteLine("Enter name to be delete");
            string Name = Console.ReadLine();
            listPersonInCity.RemoveAll(e => e.Name == Name);
            // Console.WriteLine(listPersonInCity.ToString());
            Console.WriteLine("List After deletion of " + Name);
            listPersonInCity.ForEach(x => Console.WriteLine("{0}\t", x.Name.ToString()));

        }
        #endregion

        #region uc7 Checking for dupicate entry
        public static void duplicateentry(List<Person> listPersonInCity)
        {
            Console.WriteLine("enter name to check duplicae entry");
            string Name = Console.ReadLine();
            if (listPersonInCity.Count(x => x.Name == Name) > 1)
            {
                Console.WriteLine(" there is duplicate entry for this name for " + listPersonInCity.Count(x => x.Name == Name) + "times");
            }
            else
            {
                Console.WriteLine("no duplicate entry for this name");
            }
        }
        #endregion
    }
}
