using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaInfo.Models
{
    public class PizzaModel
    {
        public string PhoneNum { get; set; }
        public int OrderId { get; set; }
        public string Toppings { get; set; }
        public string SpecialInfo { get; set; }
        public DateTime OrderDate { get; set; }
        public string Size { get; set; }
        public bool Deliver { get; set; }
    }
}