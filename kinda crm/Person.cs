using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinda_crm
{
    class Person
    {
        public uint ID;
        public string Lastname;
        public string Name;
        public uint Age;
        public string PhoneNumber;
        public string Address;

        public Person(uint ID, string lastname, string name, uint age, string phone, string address)
        {
            this.ID = ID;
            Lastname = lastname;
            Name = name;
            Age = age;
            PhoneNumber = phone;
            Address = address;

        }
    }
}
