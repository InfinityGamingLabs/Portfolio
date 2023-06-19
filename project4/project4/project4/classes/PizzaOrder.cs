using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace project4.classes
{
    public class PizzaOrder
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public int HouseNumber { get; set; }
        public string addition { get; set; }
        public string PizzaType { get; set; }
        public string Toppings { get; set; }
        public int Price { get; set; }
        public int KlantId { get; set; }
        public string Status { get; set; }
    }
}
