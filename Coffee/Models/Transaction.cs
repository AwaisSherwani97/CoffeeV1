using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int ProductID { get; set; }
        public DateTime TransactionDate{ get; set; }
        public int Total { get; set; }
        public Product Product { get; set; }
        public Till Till { get; set; }
    }
}
