using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{

    /// <summary>
    ///  For setting the functions of Car individually we have the CarBuilder
    /// </summary>
    
    public class CarBuilder
    {
        private readonly Car _car;
        public CarBuilder()
        {
            _car = new();
        }

        /// <summary>
        ///  CarBuilder returns Car after build
        /// </summary>
        
        public Car Build()
        {
            return _car;
        }

        public CarBuilder SetType(string type)
        {
            _car.type = type;
            return this;
        }

        public CarBuilder SetColor(string color)
        {
            _car.color = color;
            return this;
        }

        public CarBuilder SetPrice(int price)
        {
            _car.price = price;
            return this;
        }

        public CarBuilder SetCompany(string company)
        {
            _car.company = company;
            return this;
        }

        public CarBuilder SetGeneration(int generation)
        {
            _car.generation = generation;
            return this;
        }
    }
}
