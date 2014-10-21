using System;
using System.Threading;

namespace lDZ_Hotel.Sources
{
    class Order
    {
        private Customer currentOrder;
        private Hotel hotel;

        public Order(Hotel hotel, Customer new_custumer)
        {
            this.currentOrder = new_custumer;
            this.hotel = hotel;
        }

        public void find_room()
        {
            new Thread(delegate()
                {
                    if (this.hotel.add_custumer(this.currentOrder)) ;

                    else
                    {
                        while (this.hotel.is_full())
                        {
                            Thread.Sleep(100);
                        }

                        this.hotel.add_custumer(this.currentOrder);
                    }
                   
                    Thread.Sleep(this.currentOrder.Time);
                    this.hotel.move_out_custumer(this.currentOrder);

                }).Start();
        }
    }
}
