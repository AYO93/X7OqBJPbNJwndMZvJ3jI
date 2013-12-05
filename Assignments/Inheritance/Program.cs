using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car("Toyota", "Hilux", "white", 9, 1.3, "Tobias");
            Vehicle bus = new Bus("Volvo", "7700", "blue", 5, 18.9, 95);

                Console.Write(car.print());
                Console.Write(bus.print());

            Console.ReadKey();

        } // Main : method

    } // Program : class

} // Assignment : namespace
