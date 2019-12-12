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
        List<Courier> couriers;

        public List<Courier> getFutarok()
        {
            return couriers;
        }

        public void setFutarok(List<Courier> futarok)
        {
            this.couriers = futarok;
        }

        public DataTable getCurieDataTableFromList()
        {
            DataTable futarDT = new DataTable();
            futarDT.Columns.Add("azon", typeof(int));
            futarDT.Columns.Add("nev", typeof(string));
            futarDT.Columns.Add("tel", typeof(string));
            foreach (Courier f in couriers)
            {
                futarDT.Rows.Add(f.getId(), f.getName(), f.getTel());
            }
            return futarDT;
        }

        private void fillCurierListFromDataTable(DataTable futardt)
        {
            foreach (DataRow row in futardt.Rows)
            {
                int id = Convert.ToInt32(row[0]);
                string name = row[1].ToString();
                string tel = row[2].ToString();
                Courier f = new Courier(id, name, tel);
                couriers.Add(f);
            }
        }
    }
}
