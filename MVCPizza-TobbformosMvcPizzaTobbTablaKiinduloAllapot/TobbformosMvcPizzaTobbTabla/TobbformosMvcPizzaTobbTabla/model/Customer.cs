using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobbbformosPizzaAlkalmazasTobbTabla.Model
{
    partial class Customer
    {
        private int id;
        private string name;
        private string address;

        public Customer(int id, string name, string address)
        {

            this.id = id;
            this.name = name;
            if (!isValidName(name))
            {
                throw new ModelMegrendeloNotValidNameExeption("A név nem megfelelő!");
            }
            if (!isValidAddress(address))
            {
                throw new ModelMegrendeloNotValidNameExeption("A cím nem megfelelő!");
            }
            this.address = address;
        }
        public void updateCustomer(Customer modified)
        {

            this.name = modified.getName();
            this.address = modified.getAddress();
        }
        private bool isValidName(string name)
        {
            if (name == string.Empty)
                return false;
            if (!char.IsUpper(name.ElementAt(0)))
                return false;
            for (int i = 1; i < name.Length; i = i + 1)
                if (!char.IsLetter(name.ElementAt(i)))
                    return false;
            return true;
        }
        private bool isValidAddress(string address)
        {
            if (address == string.Empty)
                return false;
            if (!char.IsUpper(address.ElementAt(0)))
                return false;
            for (int i = 1; i < address.Length; i = i + 1)
                if (!char.IsLetter(address[i]))
                    return false;
            return true;
        }
        public void setID(int id)
        {
            this.id = id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }
        public int getID()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public string getAddress()
        {
            return address;
        }
    }
}
