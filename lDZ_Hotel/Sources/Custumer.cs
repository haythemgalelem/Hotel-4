using System;

namespace lDZ_Hotel.Sources
{
    public class Customer
    {
        private String name;
        private int time;

        public Customer(String name, int time)
        {
            this.name = name;
            this.time = time;
        }

        public String Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public int Time
        {
            set { this.time = value; }
            get { return this.time; }
        }
    }
}
