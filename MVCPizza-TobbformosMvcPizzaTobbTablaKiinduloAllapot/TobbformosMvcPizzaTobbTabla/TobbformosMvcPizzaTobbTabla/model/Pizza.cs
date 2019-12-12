using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobbbformosPizzaAlkalmazasTobbTabla.Model
{
    partial class Pizza
    {
        private int id;
        private string name;
        private int price;

        public Pizza(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public Pizza(int id, string name, string price)
        {
            this.id = id;
            if (!isValidName(name))
                throw new ModelPizzaNotValidNameExeption("A pizza neve nem megfelelő!");
            if (!isValidPrice(price))
                throw new ModelPizzaNotValidPriceExeption("A pizza ára nem megfelelő!");
            this.name = name;
            this.price = Convert.ToInt32(price);           
        }

        public void update(Pizza modified)
        {
            this.name = modified.getNeme();
            this.price = modified.getPrice();
        }

        private bool isValidPrice(string price)
        {
            int eredmeny = 0;
            if (int.TryParse(price, out eredmeny))
                return true;
            else
                return false;
        }

        private bool isValidName(string name)
        {
            if (name == string.Empty)
                return false;
            if (!char.IsUpper(name.ElementAt(0)))
                return false;
            for (int i = 1; i < name.Length; i = i + 1)
                if (
                    !char.IsLetter(name.ElementAt(i))
                        &&
                    (!char.IsWhiteSpace(name.ElementAt(i)))
                    
                    )
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
        public void setPrice(int price)
        {
            this.price = price;
        }
        public int getId()
        {
            return id;
        }
        public string getNeme()
        {
            return name;
        }
        public int getPrice()
        {
            return price;
        }
    }
}
