﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method___Class_practices
{
    public class Order
    {
        public DateTime Date  { get; set; }
        public double Price { get; set; }

        public Order(DateTime date, double price)   
        {

            Date = date;
            Price = price;

        }



    }
}
