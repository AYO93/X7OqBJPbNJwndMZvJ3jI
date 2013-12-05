/**
 * Regent University College of Science and Technology
 * ---------------------------------------------------
 * Course: Application Programming with C#
 * Student: Tobias Manuel Poganiuch
 * ---------------------------------------------------
 * Class: Stock
 * Date: 2013-12-05
 * Version: 1.1
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel;

namespace PoS_new
{
    public class Stock
    {
        // Singleton
        private static Stock stock;

        public static Stock Instance
        {
            get
            {
                if (stock == null)
                    stock = new Stock();

                return stock;
            }
        }
        // Singleton

        // Attributes
        private CSV csv;
        private string path;
        private BindingList<Product> Products;

        private Stock()
        {
            csv = new CSV();
            path = @"Core\Products.csv";
            Products = readProductsFromFile();

        } // Stock : constructor

        public void addProduct(Product product)
        {

        
        } // addProduct(Product) : method

        public void addProduct(string[] pro)
        {
            int ID;
            decimal Price;

            Int32.TryParse(pro[0], out ID);
            Decimal.TryParse(pro[2], out Price);

            Products.Add(new Product(ID, pro[1], Price, pro[3]));
            writeProductsToFile();

        } // addProduct(string) : method

        public BindingList<Product> getStock()
        {
            return Products;
        
        } // getStock : method

        public BindingList<Product> getProducts()
        {
            BindingList<Product> dummy = new BindingList<Product>();

            foreach (Product product in Products)
                dummy.Add(product);

            return dummy;
        
        } // getProducts : method

        public BindingList<Product> readProductsFromFile()
        {
            BindingList<Product> Products = new BindingList<Product>();

            foreach (string[] line in csv.read(path))
            {
                int ID = 0;
                decimal Price = 0;

                // Parse ID and Price
                Int32.TryParse(line[0], out ID);
                Decimal.TryParse(line[2], out Price);

                // Add Product to Products
                Products.Add(new Product(ID, line[1], Price, line[4]));
            }

            return Products;

        } // readProductsFromFile : method

        public void writeProductsToFile()
        {
            List<string[]> products = new List<string[]>();

            foreach (Product pro in Products)
                products.Add(pro.ToStringArray());

            csv.write(path, products);

        } // writeProductsToFile : method

    } // Core : class
} // PoS_new : namespace
