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
        List<Customer> customers;
        public List<Customer> getCustomerk()
        {
            return customers;
        }
        public void setCustomer(List<Customer> cusomers)
        {
            this.customers = cusomers;
        }
        public DataTable CustomerListToDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Azonosito", typeof(int));
            dt.Columns.Add("Nev", typeof(string));
            dt.Columns.Add("Cím", typeof(string));
            foreach (Customer m in customers)
            {
                dt.Rows.Add(m.getID(), m.getName(), m.getAddress());
            }
            return dt;
        }
        public void DataTableToCustomerList(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row[0]);
                string nev = row[1].ToString();
                string cim = row[2].ToString();
                Customer m = new Customer(id, nev, cim);
                customers.Add(m);
            }
        }
    }
}
