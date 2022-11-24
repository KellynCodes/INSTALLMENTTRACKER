namespace INSTALLMENTTRACKER
{
    internal class Program
    {
        private enum plan
        {
            Daily = 1,
            weekly = 2,
            biWeekly = 3,
            monthly = 4,
            yearly = 5,
        }
        static void Main(string[] args)
        {
            Console.Title = "Customer Installation Tracker";
            ChooseInstallmentPlan();

            //How to pay back codes
             void ChooseInstallmentPlan()
            {
            Console.WriteLine("How would you like to pay back\n");
            Console.WriteLine("1. Pay back daily.\n");
            Console.WriteLine("2. Pay back weekly.\n");
            Console.WriteLine("3. Pay back bi-weekly.\n"); 
            Console.WriteLine("4. Pay back monthly.\n"); 
            Console.WriteLine("5. Pay back Yearly.\n");

            //switch case for each choice
            string choice = Console.ReadLine(); 
            if (int.TryParse(choice, out int userChoice)) 
            {

                switch (userChoice)
                {
                    case (int)plan.Daily:
                            Installments.daily();
                        break;
                    case (int)plan.weekly:
                            Installments.weekly();
                        break;
                        case (int)plan.biWeekly: Installments.biWeekly();
                        break;
                    case (int)plan.monthly: Console.Write("Monthly");
                        break;
                    case (int)plan.yearly: Console.Write("Yearly");
                        break;
                    default: Console.WriteLine("Wrong input");
                        break;
                } 
            }
            else
            {
                Console.WriteLine($"{choice} is not in a good format. Enter only numbers");
                ChooseInstallmentPlan();
            }
           }
        }
    }
}