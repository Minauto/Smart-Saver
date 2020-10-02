using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSaver
{
    public class Deposit
    {
        // Time when deposit was made
        public DateTime time { get; set; }

        // Amount of the deposit in euros
        public int amount { get; set; }

        public Deposit(int amount)
        {
            this.amount = amount;
            time = DateTime.Now;
        }

        // parameterless constructor needed for XML serialization
        public Deposit()
        {
            amount = 0;
            time = DateTime.Now;
        }
    }
}
