using System.ComponentModel.DataAnnotations;

namespace INSTALLMENTTRACKER
{
    internal class Installments
    {
        DateTime _date;


        private enum Week
        {
            addSevenToGiveWeek = 7,
            addFourtenToGiveTwoWeeks = 14
        }
        private enum Percentages
        {
            dailyPercentage = 5,
            weeklyPercentage = 10,
            biWeeklyPercentage = 15,
            monthlyPercentage = 20,
            yearlyPercentage = 25,
        }

        private enum ValidatorNumbers : int
        {
            zero = 0,
            DivisibleBytwo = 2,
            MinumAllowedAmount = 10,
        }

        //Weekly payment code implementations
        public static void Daily()
        {
            Tracker tracker = new();
            var Customer = tracker.CustomerName();
            var Product = tracker.ProductName();
            var Price = tracker.CollectPrice();
            DateTime Date;

        Start: Console.WriteLine("How much do your want to pay Daily");
            string enteredAmount = Console.ReadLine() ?? string.Empty;
            if (decimal.TryParse(enteredAmount, out decimal Amount))
            {
                if (Amount > Price)
                {
                    Console.WriteLine($"Amount can not be greater than Price [{Price}]");
                    goto Start;
                }
                if (Amount < (int)ValidatorNumbers.MinumAllowedAmount)
                {
                    Console.WriteLine($"Amount should be greater than 9");
                    goto Start;
                }
                if (Amount == Price)
                {
                    Console.WriteLine($"Amount should be less than product price. [{Price}]");
                    goto Start;
                }
                if (Amount % (int)ValidatorNumbers.DivisibleBytwo == (int)ValidatorNumbers.zero)
                {
                    
                decimal dividedAmount = (Price / Amount);
                Date = DateTime.Now.AddDays((double)dividedAmount);
                Console.Clear();
                Console.WriteLine($"{Customer} due pay date will be on {Date} and {Customer}  have to pay {enteredAmount}  every day for {dividedAmount} days");
                Console.WriteLine($"The product {Customer} purchased is {Product}");
                decimal calculateAmount = (decimal)Percentages.dailyPercentage * dividedAmount;
                decimal totalAmount = Price + calculateAmount;
                Console.WriteLine($"The total amount {Customer} will pay on {Date} is: {totalAmount} on {(int)Percentages.dailyPercentage}% interest");
                }
                else
                {
                    Console.WriteLine("Number must be divisable by 2 i.e It can be divided by 2");
                    goto Start;
                }

            }
            else
            {
                Console.WriteLine("Entered number is not valid.\n > Enter only numbers");
                Daily();
            }

        }


        public static void Weekly()
        {
            Tracker tracker = new();
            var Customer = tracker.CustomerName();
            var Product = tracker.ProductName();
            var Price = tracker.CollectPrice();
            DateTime Date;

        Start: Console.WriteLine("How much do your want to pay weekly");
            string enteredAmount = Console.ReadLine() ?? String.Empty;
            if (decimal.TryParse(enteredAmount, out decimal Amount))
            {
                if (Amount > Price)
                {
                    Console.WriteLine($"Amount can not be greater than Price [{Price}]");
                    goto Start;
                }
                if (Amount < (int)ValidatorNumbers.MinumAllowedAmount)
                {
                    Console.WriteLine($"Amount should be greater than 9");
                    goto Start;
                }
                if (Amount == Price)
                {
                    Console.WriteLine($"Amount should be less than product price. [{Price}]");
                    goto Start;
                }
                if (Amount % (int)ValidatorNumbers.DivisibleBytwo == (int)ValidatorNumbers.zero)
                {

                    decimal dividedAmount = (Price / Amount);
                Date = DateTime.Now.AddDays((double)dividedAmount * (double)Week.addSevenToGiveWeek);
                Console.Clear();
                Console.WriteLine($"{Customer} due pay date will be on {Date} and {Customer}  have to pay {enteredAmount}  every week for {dividedAmount} weeks");
                Console.WriteLine($"The product {Customer} purchased is {Product}");
                decimal calculateAmount = (decimal)Percentages.weeklyPercentage * dividedAmount;
                decimal totalAmount = Price + calculateAmount;
                Console.WriteLine($"The total amount {Customer} will pay on {Date} is: {totalAmount} on {(int)Percentages.weeklyPercentage}% interest");
                }
                else
                {
                    Console.WriteLine("Number must be divisable by 2 i.e It can be divided by 2");
                    goto Start;
                }
            }
            else
            {
                Console.WriteLine("Entered number is not valid.\n > Enter only numbers");
                Weekly();
            }

        }

 
    //Weekly payment code implementations
    public static void BiWeekly()
        {
            Tracker tracker = new();
            var Customer = tracker.CustomerName();
            var Product = tracker.ProductName();
            var Price = tracker.CollectPrice();

            DateTime Date;

            Start: Console.WriteLine("How much do your want to pay in 2 weeks");
            string enteredAmount = Console.ReadLine() ?? String.Empty;
            if (decimal.TryParse(enteredAmount, out decimal Amount))
            {
                if (Amount > Price)
                {
                    Console.WriteLine($"Amount can not be greater than Price [{Price}]");
                    goto Start;
                }
                if (Amount < (int)ValidatorNumbers.MinumAllowedAmount)
                {
                    Console.WriteLine($"Amount should be greater than 9");
                    goto Start;
                }
                if (Amount == Price)
                {
                    Console.WriteLine($"Amount should be less than product price. [{Price}]");
                    goto Start;
                }
                if (Amount % (int)ValidatorNumbers.DivisibleBytwo == (int)ValidatorNumbers.zero)
                {

                    decimal dividedAmount = (Price / Amount);
                decimal getBiWeekly = dividedAmount + dividedAmount;
                Date = DateTime.Now.AddDays((double)dividedAmount * (double)Week.addFourtenToGiveTwoWeeks);
                Console.Clear();
                Console.WriteLine($"{Customer} due pay date will be on {Date} and {Customer}  have to pay {enteredAmount}  every  2 weeks for {getBiWeekly} weeks");
                Console.WriteLine($"The product {Customer} purchased is {Product}");
                decimal calculateAmount = (decimal)Percentages.biWeeklyPercentage * getBiWeekly;
                decimal totalAmount = Price + calculateAmount;
                Console.WriteLine($"The total amount {Customer} will pay on {Date} is: {totalAmount} on {(int)Percentages.biWeeklyPercentage}% interest");
                }
                else
                {
                    Console.WriteLine("Number must be divisable by 2 i.e It can be divided by 2");
                    goto Start;
                }
            }
            else
            {
                Console.WriteLine("Entered number is not valid.\n > Enter only numbers");
                BiWeekly();
            }
        }


        //monthly 
        public static void Monthly()
        {
            Tracker tracker = new();
            var Customer = tracker.CustomerName();
            var Product = tracker.ProductName();
            var Price = tracker.CollectPrice();
            DateTime Date;

        Start: Console.WriteLine("How much do your want to pay monthly");
            string enteredAmount = Console.ReadLine() ?? String.Empty;
            if (decimal.TryParse(enteredAmount, out decimal Amount)) 
            {
                if (Amount > Price)
                {
                    Console.WriteLine($"Amount can not be greater than Price [{Price}]");
                    goto Start;
                }
                if (Amount < (int)ValidatorNumbers.MinumAllowedAmount)
                {
                    Console.WriteLine($"Amount should be greater than 9");
                    goto Start;
                }
                if (Amount == Price)
                {
                    Console.WriteLine($"Amount should be less than product price. [{Price}]");
                    goto Start;
                }
                if (Amount % (int)ValidatorNumbers.DivisibleBytwo == (int)ValidatorNumbers.zero)
                {

                    decimal dividedAmount = (Price / Amount);
                    try
                    {
                Date = DateTime.Now.AddMonths((int)dividedAmount);

                    }
                    catch (Exception exception)
                    {
                        Console.Clear();
                        Console.WriteLine(exception.Message);Console.WriteLine($"The amount you choosed to pay every Month was either too Large or small to divide {Price}. Please try again");
                        goto Start;
                    }
                Console.Clear();
                Console.WriteLine($"{Customer} due pay date will be on {Date} and {Customer}  have to pay {enteredAmount}  every month for {dividedAmount} months");
                Console.WriteLine($"The product {Customer} purchased is {Product}");
                decimal calculateAmount = (decimal)Percentages.monthlyPercentage * dividedAmount;
                decimal totalAmount = Price + calculateAmount;
                Console.WriteLine($"The total amount {Customer} will pay on {Date} is: {totalAmount} on {(int)Percentages.monthlyPercentage}% interest");
                }
                else
                {
                    Console.WriteLine("Number must be divisable by 2 i.e It can be divided by 2");
                    goto Start;
                }
            }
            else
            {
                Console.WriteLine("Entered number is not valid.\n > Enter only numbers");
                Monthly();
            }

        }


        //Yearly 
        public static void Yearly()
        {
            Tracker tracker = new();
            Installments installments = new();
            var Customer = tracker.CustomerName();
            var Product = tracker.ProductName();
            var Price = tracker.CollectPrice();

        Start: Console.WriteLine("How much do your want to pay yearly");
            string enteredAmount = Console.ReadLine() ?? String.Empty;
            if (decimal.TryParse(enteredAmount, out decimal Amount))
            {
                if (Amount > Price)
                {
                    Console.WriteLine($"Amount can not be greater than Price [{Price}]");
                    goto Start;
                }
                if (Amount < (int)ValidatorNumbers.MinumAllowedAmount)
                {
                    Console.WriteLine($"Amount should be greater than 9");
                    goto Start;
                }
                if (Amount == Price)
                {
                    Console.WriteLine($"Amount should be less than product price. [{Price}]");
                    goto Start;
                }
                if (Amount % (int)ValidatorNumbers.DivisibleBytwo == (int)ValidatorNumbers.zero)
                {

                    decimal dividedAmount = (Price / Amount);
                    try
                    {
                     installments._date = DateTime.Now.AddYears((int)dividedAmount);

                    }
                    catch (Exception exception)
                    {
                        Console.Clear();
                        Console.WriteLine(exception.Message);
                        Console.WriteLine($"Number is too small to divide {Price}");
                        goto Start;
                    }
                Console.Clear();
                Console.WriteLine($"{Customer} due pay date will be on {installments._date} and {Customer}  have to pay {enteredAmount}  every year for {dividedAmount} years");
                Console.WriteLine($"The product {Customer} purchased is {Product}");
                decimal calculateAmount = (decimal)Percentages.yearlyPercentage * dividedAmount;
                decimal totalAmount = Price + calculateAmount;
                Console.WriteLine($"The total amount {Customer} will pay on {installments._date} is: {totalAmount} on {(int)Percentages.yearlyPercentage}% interest");
                }
                else
                {
                    Console.WriteLine("Number must be divisable by 2 i.e It can be divided by 2");
                    goto Start;
                }
            }
            else
            {
                Console.WriteLine("Entered number is not valid.\n > Enter only numbers");
                Yearly();
            }

        }

    }
}
