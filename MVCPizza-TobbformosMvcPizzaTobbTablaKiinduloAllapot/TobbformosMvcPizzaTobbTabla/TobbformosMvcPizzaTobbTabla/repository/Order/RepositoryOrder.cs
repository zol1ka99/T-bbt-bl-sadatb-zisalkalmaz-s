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
        List<Order> orders;

        public List<Order> getOrders()
        {
            return orders;
        }

        public void setOrder(List<Order> orders)
        {
            this.orders = orders;
        }


   
        public DataTable getOrderDataTableFromList()
        {
            DataTable pizzaDT = new DataTable();
            pizzaDT.Columns.Add("razon", typeof(int));
            pizzaDT.Columns.Add("vazon", typeof(string));
            pizzaDT.Columns.Add("fazon", typeof(int));
            pizzaDT.Columns.Add("datum", typeof(string));
            pizzaDT.Columns.Add("ido", typeof(double));
            foreach (Order o in orders)
            {
                pizzaDT.Rows.Add(o.getOrderId(), o.getCustomerId(), o.getCourierId(), o.getDate(), o.getTime());
            }
            return pizzaDT;
        }

    }
}
