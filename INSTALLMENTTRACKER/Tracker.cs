namespace INSTALLMENTTRACKER
{
    internal class Tracker
    {
        private string? _customerName;
        private string? _productName;
        private decimal _price;



        public string CustomerName()
        {
            Console.WriteLine("Note: whatever you put here will be the name of the Customer");
            Console.WriteLine("Enter Customer Fullname");
            _customerName = Console.ReadLine() ?? String.Empty;
            if (string.IsNullOrEmpty(_customerName.Trim()))
            {
                Console.WriteLine("Please Enter customer name");
                CustomerName();
            }
            return _customerName;
        }

        public string ProductName()
        {
            Console.WriteLine("Note: whatever you put here will be the name of the product");
            Console.WriteLine("Enter Product name");
            _productName = Console.ReadLine() ?? String.Empty;
            if (string.IsNullOrEmpty(_productName.Trim()))
            {
                Console.WriteLine("Enter product name");
                ProductName();
            }
            return _productName;
        }

        public decimal CollectPrice()
        {
          Start: Console.WriteLine("Enter product price");
            string? price = Console.ReadLine();
            if (decimal.TryParse(price, out decimal productPrice))
            {
                if (productPrice < 10)
                {
                    Console.WriteLine($"Product price cannot be below 10");
                    goto Start;
                }
                _price = productPrice;
            }
            else
            {
                Console.WriteLine($"{price} is not a valid input. Surported input are digits");
                CollectPrice();
            }
            return _price;
        }


    }
}