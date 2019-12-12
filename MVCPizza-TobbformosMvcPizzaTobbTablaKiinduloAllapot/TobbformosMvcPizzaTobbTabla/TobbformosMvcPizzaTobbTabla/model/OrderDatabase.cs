using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobbbformosPizzaAlkalmazasTobbTabla.Model
{
    partial class Order
    {
        public static string getSQLCommandGetAllRecord()
        {
            return "SELECT * FROM prendeles";
        }

        public static string getSQLCommandDeleteAllRecord()
        {
            return "DELETE FROM prendeles";
        }

    }
}
