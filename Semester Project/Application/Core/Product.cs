/**
 * Regent University College of Science and Technology
 * ---------------------------------------------------
 * Course: Application Programming with C#
 * Student: Tobias Manuel Poganiuch
 * ---------------------------------------------------
 * Class: Product
 * Date: 2013-12-05
 * Version: 1.1
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointOfSale
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }

        public Product(int ID, string Name, decimal Price, string Description)
        {
            this.ID = ID;
            this.Name = Name;
            this.Price = Price;
            this.Description = Description;

        } // Product : constructor

        public bool Contains(string value)
        {
            if (Name.ToLower().Contains(value.ToLower()) || Description.ToLower().Contains(value.ToLower()))
                return true;
            else
                return false;

        } // Contains : method

        public override string ToString()
        {
            return ID + " - " + Name + " - " + Description;

        } // ToString : method

        public string[] ToStringArray()
        {
            string[] str = { ID.ToString(), Name, Price.ToString(), Description };
            return str;

        } // ToStringArray : method

    } // Product : class
} // namespace
