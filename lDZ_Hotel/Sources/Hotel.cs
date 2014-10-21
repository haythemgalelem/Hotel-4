using System;
using System.Collections.Generic;
//using System.Convert;
using lDZ_Hotel.Sources;


namespace lDZ_Hotel.Sources
{
    public class Hotel
    {
        private int size;
        private int capacity;
        private List<Customer> custumers;
       
    
        public Hotel()
        {
            this.size = 2;
            this.capacity = 0;
            this.custumers = new List<Customer>();
        }

        public int Size
        {
            set { this.size = value; }
            get { return this.size; }
        }

        public int Capacity
        {
            get { return this.capacity; }
            set { this.capacity = this.custumers.Capacity; }
        }

        public bool is_full()
        {
            if (this.Capacity != this.Size)
                return false;
            else 
                return true;
        }

        public bool add_custumer(Customer new_custumer)
        {
            if (!is_full())
            {
                this.custumers.Add(new_custumer);
                this.capacity = this.custumers.Count;

                Console.WriteLine();
                Console.WriteLine("Hotel: \t {0} поселений. Залишилось {1} мiсць.", new_custumer.Name, this.Size - this.Capacity);
                return true;
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Hotel: \t\t В горелi бракує мiсць. Заявка вiдхилена.");
                return false;
            }
        }

        public void move_out_custumer(Customer current)
        {
            this.custumers.Remove(current);
            this.Capacity = this.custumers.Count;

            Console.WriteLine();
            Console.WriteLine("Hotel: \t\t\t {0} залишив готель, пробувши {1} секунд.", current.Name, current.Time / 1000);
        }
    }
}
