﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaInfo.Models
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}