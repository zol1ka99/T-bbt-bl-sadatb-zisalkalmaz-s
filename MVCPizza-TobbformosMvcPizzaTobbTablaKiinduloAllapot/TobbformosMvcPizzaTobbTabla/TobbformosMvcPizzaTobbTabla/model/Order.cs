using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobbbformosPizzaAlkalmazasTobbTabla.Model
{
    partial class Order
    {
        private int orderId;
        private int customerId;
        private int courierId;
        private string date;
        private double time;

        public Order(int orderId, int customerId, int courierId, string date, double time)
        {
            this.orderId = orderId;
            this.customerId = customerId;
            this.courierId = courierId;
            this.date = date;
            this.time = time;
        }

        public int getOrderId()
        {
            return orderId;
        }

        public int getCustomerId()
        {
            return customerId;
        }

        public int getCourierId()
        {
            return courierId;
        }

        public string getDate()
        {
            return date;
        }

        public double getTime()
        {
            return time;
        }

    }
}
