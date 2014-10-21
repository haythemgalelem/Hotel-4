using System;
using System.Threading;

namespace lDZ_Hotel.Sources
{
    class Order
    {
        private Customer currentCustomer;
        private Hotel hotel;

        public Order(Hotel hotel, Customer new_custumer)
        {
            this.currentCustomer = new_custumer;
            this.hotel = hotel;
        }

        public void find_room()
        {
            new Thread(delegate()
                {
                    if (this.hotel.add_custumer(this.currentCustomer)) ;

                    else
                    {
                        while (this.hotel.is_full())
                        {
                            Thread.Sleep(100);
                        }

                        this.hotel.add_custumer(this.currentCustomer);
                    }
                   
                    Thread.Sleep(this.currentCustomer.Time);
                    this.hotel.move_out_custumer(this.currentCustomer);

                }).Start();
        }
    }
}
