using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TobbbformosPizzaAlkalmazasTobbTabla.Model;

namespace TobbbformosPizzaAlkalmazasTobbTabla.Repository
{
    partial class Repository
    {
        public Repository()
        {
            pizzas = new List<Pizza>();
            customers = new List<Customer>();
            couriers = new List<Courier>();
        }        
    }
}
