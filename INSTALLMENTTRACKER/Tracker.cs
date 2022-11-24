using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSTALLMENTTRACKER
{
    internal class Tracker
    {
        private string? _customerName;
        private string? _productName;
        private decimal _price;
        private string? _description;
        

      
        public string customerName()
        {
            Console.WriteLine("Enter Customer Fullname");
            _customerName = Console.ReadLine() ?? String.Empty;
            if (string.IsNullOrEmpty(_customerName.Trim()))
            {
                Console.WriteLine("Please Enter customer name");
                customerName();
            }

            return _customerName;
        }

        public string productName()
        {
            Console.WriteLine("Enter Product name");
            _productName = Console.ReadLine() ?? String.Empty;
            if (string.IsNullOrEmpty(_productName.Trim()))
            {
                Console.WriteLine("Enter product name");
                productName();
            }
            return _productName;
        }
       
        public decimal collectPrice()
        {
            Console.WriteLine("Enter product price");
            string? price = Console.ReadLine();
            if (decimal.TryParse(price, out decimal productPrice))
            {
                _price = productPrice;
            }
            else
            {
                Console.WriteLine($"{price} is not a valid input. Surported input are digits");
                collectPrice();
            }
            return _price;
        }

      
    }
}