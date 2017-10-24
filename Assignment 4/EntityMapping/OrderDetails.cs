﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityMapping
{
    public class OrderDetails
    {
        //teeeeeeeeeeeeeeeeest
        [Key, Column("OrderID", Order = 0)]
        public int OrderId { get; set; }

        [Key, Column("ProductID", Order = 1)]
        public int ProductId { get; set; }

        public double UnitPrice { get; set; }

        public int Quantity { get; set; }

        public double Discount { get; set; }

        public Product Product { get; set; }

        public Order Order { get; set; }


    }
}
