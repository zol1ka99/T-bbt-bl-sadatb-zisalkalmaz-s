using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using TobbbformosPizzaAlkalmazasTobbTabla.Model;

namespace TobbbformosPizzaAlkalmazasTobbTabla.Repository
{
    partial class Repository
    {
        List<Pizza> pizzas;

        public List<Pizza> getPizzas()
        {
            return pizzas;
        }

        public void setPizzas(List<Pizza> pizzas)
        {
            this.pizzas = pizzas;
        }


   /*     public void setTestData()
        {
            pizzas.Add(new Pizza(1, "Capricciosa", 900));
            pizzas.Add(new Pizza(2, "Frutti di Mare", 1100));
            pizzas.Add(new Pizza(3, "Hawaii", 780));
            pizzas.Add(new Pizza(4, "Vesuvio", 890));
            pizzas.Add(new Pizza(5, "Sorrento", 990));
        }*/

        public DataTable getPizzaDataTableFromList()
        {
            DataTable pizzaDT = new DataTable();
            pizzaDT.Columns.Add("azon", typeof(int));
            pizzaDT.Columns.Add("nev", typeof(string));
            pizzaDT.Columns.Add("ar", typeof(int));
            foreach (Pizza p in pizzas)
            {
                pizzaDT.Rows.Add(p.getId(), p.getNeme(), p.getPrice());
            }
            return pizzaDT;
        }

        private void fillPizzaListFromDataTable(DataTable pizzadt)
        {
            foreach (DataRow row in pizzadt.Rows)
            {
                int azon = Convert.ToInt32(row[0]);
                string nev = row[1].ToString();
                int ar = Convert.ToInt32(row[2]);
                Pizza p = new Pizza(azon, nev, ar);
                pizzas.Add(p);
            }
        }

        public void deletePizzaFromList(int id)
        {
            Pizza p = pizzas.Find(x => x.getId() == id);
            if (p != null)
                pizzas.Remove(p);
            else
                throw new RepositoryExceptionCantDelete("A pizzát nem lehetett törölni.");
        }

        public void updatePizzaInList(int id,Pizza modified)
        {
            Pizza p = pizzas.Find(x => x.getId() == id);
            if (p != null)
                p.update(modified);
            else
                throw new RepositoryExceptionCantModified("A pizza módosítása nem sikerült");
        }

        public void addPizzaToList(Pizza ujPizza)
        {
            try
            {
                pizzas.Add(ujPizza);
            }
            catch (Exception e)
            {
                throw new RepositoryExceptionCantAdd("A pizza hozzáadása nem sikerült");
            }
        }

        public Pizza getPizza(int id)
        {
            return pizzas.Find(x => x.getId() == id);
        }

        public int getNextPizzaId()
        {
            if (pizzas.Count == 0)
                return 1;
            else
                return pizzas.Max(x => x.getId()) + 1;
        }
    }
}
