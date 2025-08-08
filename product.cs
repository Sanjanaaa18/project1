using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Product
    {
        //data members
        private string productName;
        private double productPrice;
        private double productQuantity;

        //constructor
        public Product()//default constructor
        {
        }
        // Rename the private fields to avoid name collision with properties
       

        // Update constructors and methods to use the renamed fields
        
        //parameterized constructor or overloaded constructor
        public Product(string name, double price, int quantity)
        {
            this.productName = name;
            this.productPrice = price;
            this.productQuantity = quantity;
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        //property for productprice
        public double ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }
        
        public double ProductQuantity
        {
            get { return productQuantity; }
            set { productQuantity = value; }
        }
        public void displayProductDetails()
        {
            Console.WriteLine($"Product Name: {productName}");
            Console.WriteLine($"Product Price: {productPrice}");
            Console.WriteLine($"Product Quantity: {productQuantity}");
        }
        public double calculateTotalPrice()
        {
            return productprice * productQuantity;
        }
        public double calculateDiscountedPrice(double discountPercentage)
        {
            double discountAmount = (productprice * discountPercentage) / 100;
            return productprice - discountAmount;
        }
        public bool isAvailable(int requiredQuantity)
        {
            return productQuantity >= requiredQuantity;
        }
        public void updateProductQuantity(int quantity)
        {
            if (quantity < 0)
            {
                Console.WriteLine("Quantity cannot be negative.");
            }
            else
            {
                productQuantity = quantity;
                Console.WriteLine($"Product quantity updated to: {productQuantity}");
            }
        }
        //method to display product details
        public double productprice
        {
            get { return productprice; }
            set { productprice = value; }
        }
        
        
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product Name: {productName}");
            Console.WriteLine($"Product Price: {productPrice}");
            Console.WriteLine($"Product Quantity: {productQuantity}");
        }
        public double CalculateTotalPrice()
        {
            return productprice * productQuantity;
        }
        public double CalculateDiscountedPrice(double discountPercentage)
        {
            double discountAmount = (productprice * discountPercentage) / 100;
            return productprice - discountAmount;
        }
        public bool IsAvailable(int requiredQuantity)
        {
            return productQuantity >= requiredQuantity;
        }
        public void UpdateProductQuantity(int quantity)
        {
            if (quantity < 0)
            {
                Console.WriteLine("Quantity cannot be negative.");
            }
            else
            {
                productQuantity = quantity;
                Console.WriteLine($"Product quantity updated to: {productQuantity}");
            }
        }
    }
}
