using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobbbformosPizzaAlkalmazasTobbTabla.Model
{
    partial class Item
    {
        private int orderId;
        private int pizzaId;
        private int piece;

        public Item(int orderId, int pizzaId, int piece)
        {
            this.orderId = orderId;
            this.pizzaId = pizzaId;
            this.piece = piece;
        }

        public int getOrderId()
        {
            return orderId;
        }

        public int getPizzaId()
        {
            return pizzaId;
        }

        public int getPiece()
        {
            return piece;
        }
    }
}
