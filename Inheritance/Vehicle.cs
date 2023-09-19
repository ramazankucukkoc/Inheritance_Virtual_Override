using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Vehicle (Araç)

    public class Vehicle
    {
        public string BrandName { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string brandName, string model, int year)
        {
            BrandName = brandName;
            Model = model;
            Year = year;
        }

        public virtual void Run()
        {
            Console.WriteLine($"{BrandName} {Model} running !!!");
        }
        public virtual void Stop()
        {
            Console.WriteLine($"{BrandName} {Model} stopped !!! ");
        }
    }
}
