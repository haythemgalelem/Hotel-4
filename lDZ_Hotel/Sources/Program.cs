using System;
using System.Threading;
using lDZ_Hotel.Sources;

namespace lDZ_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            Order new_order = new Order(hotel, new Customer("Vlad", 10000));
            new_order.find_room();

            for (int c = 0; c < 1000000000; ) c++;

            Order order2 = new Order(hotel, new Customer("Alexander", 3000));
            order2.find_room();

            for (int c = 0; c < 80000000; ) c++;

            Order order3 = new Order(hotel, new Customer("Victor", 6000));
            order3.find_room();

            for (int c = 0; c < 600000000; ) c++;

            Order order4 = new Order(hotel, new Customer("Jon", 10000));
            order4.find_room();

            for (int c = 0; c < 800000000; ) c++;

            Order order5 = new Order(hotel, new Customer("Nick", 4000));
            order5.find_room();


            Console.Read();
        }

     
    }
}
