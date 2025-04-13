using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    public class PersonBL
    {
        protected string name;
        protected string address;

        public PersonBL(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public string GetName()
        {
            return name;
        }

        public string GetAddress()
        {
            return address;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public override string ToString()
        {
            return $"Person[name={name},address={address}]";
        }
    }
}
