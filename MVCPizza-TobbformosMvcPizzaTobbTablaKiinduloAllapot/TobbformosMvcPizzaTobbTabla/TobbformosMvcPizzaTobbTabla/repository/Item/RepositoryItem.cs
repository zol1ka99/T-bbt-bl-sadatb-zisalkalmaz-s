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
        List<Item> items;

        public List<Item> getItems()
        {
            return items;
        }

        public void setItem(List<Item> orders)
        {
            this.items = items;
        }


   
        public DataTable getItemDataTableFromList()
        {
            DataTable orderDT = new DataTable();
            orderDT.Columns.Add("razon", typeof(int));
            orderDT.Columns.Add("pazon", typeof(int));
            orderDT.Columns.Add("db", typeof(int));
            foreach (Item i in items)
            {
                orderDT.Rows.Add(i.getOrderId(),i.getPizzaId(),i.getPiece());
            }
            return orderDT;
        }
    }
}
