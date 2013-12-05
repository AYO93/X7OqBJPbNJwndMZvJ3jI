using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment
{
    class Car : Vehicle
    {
        private string owner;

        public void SetOwner(string owner) { this.owner = owner; }
        public string GetOwner() { return owner; }

        public Car() {

            SetOwner("Max Mustermann");

        } // Car : constructor

        public Car(string manufacturer, string model, string color, int age, double weight, string owner) : base(manufacturer, model, color, age, weight) {

            this.owner = owner;
        
        } // Car : constructor

        public override string print() {

            string str = "--- Car ---\n";

                str += "Owner: " + owner + "\n";
                str += "--- --- ---\n";
                str += "Manufacturer: " + GetManufacturer() + "\n";
                str += "Model: " + GetModel() + "\n";
                str += "Color: " + GetColor() + "\n";
                str += "Age: " + GetAge() + " years\n";
                str += "Weight: " + GetWeight() + " t\n";
                str += "\n";

            return str;

        } // print : method

    } // Car : class

} // Assignment : namespace
