using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee.Models
{
    public class Till
    {
        public int TillID { get; set; }
        public int TillNumber { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
