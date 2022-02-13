using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            SSN=Console.ReadLine();
            Console.WriteLine("Name" + Name);
            Name=Console.ReadLine();
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
        }

        

    }


}
