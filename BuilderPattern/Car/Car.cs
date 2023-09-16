using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{

    /// <summary>
    ///    Type, color, price, company, generation are the properties associated with Car 
    /// </summary>

    public class Car
    {
        public string type;
        public string color;
        public int price;
        public string company;
        public int generation;
        public Car()
        {
            price = 0;
            type = "";
            color = "";
            company = "";
            generation = 0;
        }
    }
}
