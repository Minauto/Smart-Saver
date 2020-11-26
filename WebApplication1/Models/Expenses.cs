using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    internal class Expences
    {
        public int UserId { get; set; }
        public decimal ExpencesF { get; set; }
        public string ExpencesType { get; set; }
        public DateTime Date { get; set; }
    }
}