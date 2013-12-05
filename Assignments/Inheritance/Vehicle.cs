/**
 * Author: Tobias Poganiuch
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment
{
    abstract class Vehicle
    {
        private string manufacturer;
        private string model;
        private string color;
        private int age;
        private double weight;

        public Vehicle() {
            
            manufacturer = "default";
            model = "default";
            age = 0;
            weight = 0;

        } // Vehicle : constructor

        public Vehicle(string manufacturer, string model, string color, int age, double weight) {

            this.manufacturer = manufacturer;
            this.model = model;
            this.color = color;
            this.age = age;
            this.weight = weight;
        
        } // Vehicle : constructor

        public void SetManufacturer(string manufacturer) { this.manufacturer = manufacturer; }
        public void SetModel(string model) { this.model = model; }
        public void SetColor(string color) { this.color = color; }
        public void SetAge(int age) { this.age = age; }
        public void SetWeight(double weight) { this.weight = weight; }

        public string GetManufacturer() { return manufacturer; }
        public string GetModel() { return model; }
        public string GetColor() { return color;  }
        public int GetAge() { return age; }
        public double GetWeight() { return weight; }

        public abstract string print();

    } // Vehicle : class

} // Assignment : namespace
