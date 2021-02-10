﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
