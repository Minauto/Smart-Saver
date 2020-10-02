using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSaver
{
    public class Deposit
    {

        public DateTime time { get; set; }

        public int amount { get; set; }

        public Deposit(int amount)
        {
            this.amount = amount;
            time = DateTime.Now;
        }
    }
}
