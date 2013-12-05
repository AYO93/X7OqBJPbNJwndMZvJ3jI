using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment
{
    class Bus : Vehicle
    {
        private int seats;
        private string[] passengers;

        public Bus() {

            seats = 20;
            passengers = new string[seats];

        } // Bus : constructor

        public Bus(string manufacturer, string model, string color, int age, double weight, int seats) : base(manufacturer, model, color, age, weight) {

            this.seats = seats;
            passengers = new string[seats];

        } // Bus : constructor

        public override string print() {

            string str = "--- Bus ---\n";

                str += "Seats: " + seats + "\n";
                str += "--- --- ---\n";
                str += "Manufacturer: " + GetManufacturer() + "\n";
                str += "Model: " + GetModel() + "\n";
                str += "Color: " + GetColor() + "\n";
                str += "Age: " + GetAge() + " years\n";
                str += "Weight: " + GetWeight() + " t\n";
                str += "\n";

            return str;

        } // print : method

    } // Bus : class

} // Assignment : namespace
