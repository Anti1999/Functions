using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage esimene arv");
            int UserNumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisestage teine arv");
            int UserNumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisesta tehe (sisesta '+', '*','-' või '/') " );
            char UserOperator = Convert.ToChar(Console.ReadLine());

            switch(UserOperator)
            {
                case '+':
                    AddTwonumbers(UserNumberOne, UserNumberTwo);
                    break;
                case '/':
                    DivideTwoNumbers(UserNumberOne, UserNumberTwo);
                    break;
                case '*':
                    MultiplicationNumbers(UserNumberOne, UserNumberTwo);
                    break;
                case '-':
                    SubtractionNumbers(UserNumberOne, UserNumberTwo);
                    break;

                default:
                    Console.WriteLine("Kena päeva");
                    break;

            }
        }

        public static void AddTwonumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);

        }
        public static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);

        }
        public static void MultiplicationNumbers(int x, int y)
        {
            int result = x * y;
            Console.WriteLine(result);

        }
        public static void SubtractionNumbers(double x, double y)
        {
            double result = x - y;
            Console.WriteLine(result);

        }
    }
}
