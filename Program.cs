namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {

            float percent = 0.02f;
            float money;
            float months;

            int monthCount = 0;

            Console.WriteLine("Bank. Give money and you collect more. Percentage is 2%");

            Console.Write("How much you have money: ");
            money = Convert.ToInt32(Console.ReadLine());

            Console.Write("How long you hold money in bank(in months): ");
            months = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1 - Simple interest");
            Console.WriteLine("2 - Compound interest");
            Console.WriteLine("What is the operation you want to complete:");
            string choiceOfOperation = Console.ReadLine();

            if (choiceOfOperation == "1")
            {
                float moneyWithProfit = money;

                Console.WriteLine($"Money before: {money}");

                for (float i = months; i > 0; i--)
                {
                    moneyWithProfit += money * percent;

                    Console.WriteLine($"{++monthCount} month: {moneyWithProfit}");
                }

                money = moneyWithProfit;
            }
            else if (choiceOfOperation == "2")
            {

                Console.WriteLine($"Money before: {money}");

                for (float i = months; i > 0; i--)
                {
                    money += money * percent;
                    Console.WriteLine($"{++monthCount} month: {money}");
                }

            }
            else
            {

                Console.WriteLine("Incorrect operation! Please, repeat the request");

            }


            Console.WriteLine($"Money after {months} months: {money}");

            Console.ReadKey();
            Console.Clear();
        }
    }
}