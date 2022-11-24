namespace INSTALLMENTTRACKER
{
    internal class Installments
    {
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
        public static void daily()
        { 
            Tracker tracker = new Tracker();
            var Customer = tracker.customerName();
            var Product = tracker.productName();
            var Price = tracker.collectPrice();
            DateTime Date;

            Console.WriteLine("How much do your want to pay weekly");
            string enteredAmount = Console.ReadLine();
            if (decimal.TryParse(enteredAmount, out decimal Amount)) 
            { 
                decimal dividedAmount = (Price / Amount);
                Date = DateTime.Now.AddDays((double)dividedAmount);
                Console.WriteLine($"{Customer} due pay date will be on {Date} and {Customer}  have to pay {enteredAmount}  every day for {dividedAmount} days");
                Console.WriteLine($"The product {Customer} purchased is {Product}");
                decimal calculateAmount = (decimal)percentages.dailyPercentage * dividedAmount;
                decimal totalAmount = Price + calculateAmount;
                Console.WriteLine($"The total amount {Customer} will pay on {Date} is: {totalAmount} on {(int)percentages.dailyPercentage}% interest");
            }
            else
            {
                Console.WriteLine("Entered number is not valid.\n > Enter only numbers");
                daily();
            }

        }
      

        public static void weekly()
        {
            Tracker tracker = new Tracker();
            var Customer = tracker.customerName(); 
            var Product = tracker.productName();
            var Price = tracker.collectPrice();
            DateTime Date;

        Console.WriteLine("How much do your want to pay weekly");
            string enteredAmount = Console.ReadLine();
            if (decimal.TryParse(enteredAmount, out decimal Amount))
            {
                decimal dividedAmount = (Price / Amount);
                Date = DateTime.Now.AddDays((double)dividedAmount * (double)week.addSevenToGiveWeek);
                Console.WriteLine($"{Customer} due pay date will be on {Date} and {Customer}  have to pay {enteredAmount}  every week for {dividedAmount} weeks");
                Console.WriteLine($"The product {Customer} purchased is {Product}"); 
                decimal calculateAmount = (decimal)percentages.weeklyPercentage * dividedAmount;
                decimal totalAmount = Price + calculateAmount;
                Console.WriteLine($"The total amount {Customer} will pay on {Date} is: {totalAmount} on {(int)percentages.weeklyPercentage}% interest");
            }
            else
            {
                Console.WriteLine("Entered number is not valid.\n > Enter only numbers");
                weekly();
            }

        }


        //Weekly payment code implementations
        public static void biWeekly()
        {
            Tracker tracker = new Tracker();
            var Customer = tracker.customerName();
            var Product = tracker.productName();
            var Price = tracker.collectPrice();
            DateTime Date;

            Console.WriteLine("How much do your want to pay in 2 weeks");
            string enteredAmount = Console.ReadLine();
            if (decimal.TryParse(enteredAmount, out decimal Amount))
            {
                decimal dividedAmount = (Price / Amount);
                decimal getBiWeeklyToCalculateWithPercentage = dividedAmount * dividedAmount;
                decimal getBiWeekly = dividedAmount + dividedAmount;
                Date = DateTime.Now.AddDays((double)dividedAmount * (double)week.addFourtenToGiveTwoWeeks);
                Console.WriteLine($"{Customer} due pay date will be on {Date} and {Customer}  have to pay {enteredAmount}  every  2 weeks for {getBiWeekly} weeks");
                Console.WriteLine($"The product {Customer} purchased is {Product}");
                decimal calculateAmount = (decimal)percentages.weeklyPercentage * getBiWeeklyToCalculateWithPercentage;
                decimal totalAmount = Price + calculateAmount;
                Console.WriteLine($"The total amount {Customer} will pay on {Date} is: {totalAmount} on {(int)percentages.biWeeklyPercentage}% interest");
            }
            else
            {
                Console.WriteLine("Entered number is not valid.\n > Enter only numbers");
                biWeekly();
            }
        }
        }
}
