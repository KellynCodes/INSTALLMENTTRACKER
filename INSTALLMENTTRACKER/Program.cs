namespace INSTALLMENTTRACKER
{
    internal class Program
    {

        private enum Plan
        {
            Daily = 1,
            weekly,
            biWeekly,
            monthly,
            yearly,
        }
        static void Main(string[] args)
        {
            Console.Title = "Customer Payment Installatment Tracker";
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
                        case (int)Plan.Daily:
                            Installments.Daily();
                            break;
                        case (int)Plan.weekly:
                            Installments.Weekly();
                            break;
                        case (int)Plan.biWeekly:
                            Installments.BiWeekly();
                            break;
                        case (int)Plan.monthly:
                            Installments.Monthly();
                            break;
                        case (int)Plan.yearly:
                            Installments.Yearly();
                            break;
                        default:
                            Console.Clear(); Console.WriteLine("Wrong input, Entered number was not in the options"); ChooseInstallmentPlan();
                            break;
                    }
                    DoYouWantToExit();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"{choice} is not in a good format. Enter only numbers");
                    ChooseInstallmentPlan();
                }
            }
            void DoYouWantToExit()
            {

            WhereTheSwitchCaseStarted: Console.WriteLine("Do you want to check orther installment plans");
                Console.WriteLine("Choose [YES/NO]");
                string answer = Console.ReadLine() ?? String.Empty;
                switch (answer.Trim().ToUpper())
                {

                    case "YES":
                        ChooseInstallmentPlan();
                        break;
                    case "NO":
                        Console.WriteLine("You have Closed the application");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Entered Input is not in the options. Please choose NO or YES for us to be certain you wanted to close the application");
                        goto WhereTheSwitchCaseStarted;
                }

            }

        }
    }
}