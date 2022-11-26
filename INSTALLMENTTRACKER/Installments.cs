namespace INSTALLMENTTRACKER
{
    internal class Installments
    {
        DateTime _date;

        private enum week
        {
            addSevenToGiveWeek = 7,
            addFourtenToGiveTwoWeeks = 14
        }
        private enum percentages
        {
            dailyPercentage = 5,
            weeklyPercentage = 10,
            biWeeklyPercentage = 15,
            monthlyPercentage = 20,
            yearlyPercentage = 25,
        }

        //Weekly payment code implementations
        public static void Daily()
        {
            Tracker tracker = new Tracker();
            var Customer = tracker.CustomerName();
            var Product = tracker.ProductName();
            var Price = tracker.CollectPrice();
            DateTime Date;

        Start: Console.WriteLine("How much do your want to pay Daily");
            string enteredAmount = Console.ReadLine();
            if (decimal.TryParse(enteredAmount, out decimal Amount))
            {
                if(Amount % 2 == 0)
                {
                    
                decimal dividedAmount = (Price / Amount);
                Date = DateTime.Now.AddDays((double)dividedAmount);
                Console.Clear();
                Console.WriteLine($"{Customer} due pay date will be on {Date} and {Customer}  have to pay {enteredAmount}  every day for {dividedAmount} days");
                Console.WriteLine($"The product {Customer} purchased is {Product}");
                decimal calculateAmount = (decimal)percentages.dailyPercentage * dividedAmount;
                decimal totalAmount = Price + calculateAmount;
                Console.WriteLine($"The total amount {Customer} will pay on {Date} is: {totalAmount} on {(int)percentages.dailyPercentage}% interest");
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
            Tracker tracker = new Tracker();
            var Customer = tracker.CustomerName();
            var Product = tracker.ProductName();
            var Price = tracker.CollectPrice();
            DateTime Date;

            Start: Console.WriteLine("How much do your want to pay weekly");
            string enteredAmount = Console.ReadLine();
            if (decimal.TryParse(enteredAmount, out decimal Amount))
            {
                if (Amount % 2 == 0)
                {

                    decimal dividedAmount = (Price / Amount);
                Date = DateTime.Now.AddDays((double)dividedAmount * (double)week.addSevenToGiveWeek);
                Console.Clear();
                Console.WriteLine($"{Customer} due pay date will be on {Date} and {Customer}  have to pay {enteredAmount}  every week for {dividedAmount} weeks");
                Console.WriteLine($"The product {Customer} purchased is {Product}");
                decimal calculateAmount = (decimal)percentages.weeklyPercentage * dividedAmount;
                decimal totalAmount = Price + calculateAmount;
                Console.WriteLine($"The total amount {Customer} will pay on {Date} is: {totalAmount} on {(int)percentages.weeklyPercentage}% interest");
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
            Tracker tracker = new Tracker();
            var Customer = tracker.CustomerName();
            var Product = tracker.ProductName();
            var Price = tracker.CollectPrice();

            DateTime Date;

            Start: Console.WriteLine("How much do your want to pay in 2 weeks");
            string enteredAmount = Console.ReadLine();
            if (decimal.TryParse(enteredAmount, out decimal Amount))
            {
                if (Amount % 2 == 0)
                {

                    decimal dividedAmount = (Price / Amount);
                decimal getBiWeekly = dividedAmount + dividedAmount;
                Date = DateTime.Now.AddDays((double)dividedAmount * (double)week.addFourtenToGiveTwoWeeks);
                Console.Clear();
                Console.WriteLine($"{Customer} due pay date will be on {Date} and {Customer}  have to pay {enteredAmount}  every  2 weeks for {getBiWeekly} weeks");
                Console.WriteLine($"The product {Customer} purchased is {Product}");
                decimal calculateAmount = (decimal)percentages.biWeeklyPercentage * getBiWeekly;
                decimal totalAmount = Price + calculateAmount;
                Console.WriteLine($"The total amount {Customer} will pay on {Date} is: {totalAmount} on {(int)percentages.biWeeklyPercentage}% interest");
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
            Tracker tracker = new Tracker();
            var Customer = tracker.CustomerName();
            var Product = tracker.ProductName();
            var Price = tracker.CollectPrice();
            DateTime Date;

        Start: Console.WriteLine("How much do your want to pay monthly");
            string enteredAmount = Console.ReadLine();
            if (decimal.TryParse(enteredAmount, out decimal Amount)) 
            {
                if (Amount % 2 == 0)
                {
                        decimal dividedAmount = (Price / Amount);
                    try
                    {
                Date = DateTime.Now.AddMonths((int)dividedAmount);

                    }
                    catch (Exception exception)
                    {

                        Console.WriteLine(exception.Message);Console.WriteLine("The amount you choosed to pay every Month was either too Large or small to divide the product price. Please try again");
                        goto Start;
                    }
                Console.Clear();
                Console.WriteLine($"{Customer} due pay date will be on {Date} and {Customer}  have to pay {enteredAmount}  every month for {dividedAmount} months");
                Console.WriteLine($"The product {Customer} purchased is {Product}");
                decimal calculateAmount = (decimal)percentages.monthlyPercentage * dividedAmount;
                decimal totalAmount = Price + calculateAmount;
                Console.WriteLine($"The total amount {Customer} will pay on {Date} is: {totalAmount} on {(int)percentages.monthlyPercentage}% interest");
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
            Tracker tracker = new Tracker();
            Installments installments = new();
            var Customer = tracker.CustomerName();
            var Product = tracker.ProductName();
            var Price = tracker.CollectPrice();

        Start: Console.WriteLine("How much do your want to pay yearly");
            string enteredAmount = Console.ReadLine() ?? String.Empty;
            if (decimal.TryParse(enteredAmount, out decimal Amount)) 
            {
                if (Amount % 2 == 0)
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
                decimal calculateAmount = (decimal)percentages.yearlyPercentage * dividedAmount;
                decimal totalAmount = Price + calculateAmount;
                Console.WriteLine($"The total amount {Customer} will pay on {installments._date} is: {totalAmount} on {(int)percentages.yearlyPercentage}% interest");
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
