using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinda_crm
{
    public class Person
    {
        public uint ID;
        public string Lastname;
        public string Name;
        public int Age;
        public string PhoneNumber;
        public string Address;

        public Person(uint ID, string lastname, string name, int age, string phone, string address)
        {
            this.ID = ID;
            Lastname = lastname;
            Name = name;
            Age = age;
            PhoneNumber = phone;
            Address = address;
        }

        public int CompareTo(object obj)
        {
            if (obj is Person person) return ID.CompareTo(person.ID);
            else throw new ArgumentException("Некорректное значение параметра");
        }
    }
}
