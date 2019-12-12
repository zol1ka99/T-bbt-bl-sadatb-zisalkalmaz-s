using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobbbformosPizzaAlkalmazasTobbTabla.Model
{
    partial class Customer
    {
        public static string getSQLCommandGetAllRecord()
        {
            return "SELECT * FROM pvevo";
        }

        public static string getSQLCommandDeleteAllRecord()
        {
            return "DELETE FROM pvevo";
        }
    }
}
