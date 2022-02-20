using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //Programm palub kasutajal valida number 1-3ni
            //Kui kasutaja valib '1', siis programm kuvab kasutaja nime tagurpidi
            //kui kasutaja valib '2', siis programm kuvab kasutaja eesnime esimest tähte
            //kui kasutaja valib '3' siis programm kuvab kasutja eesnime pikkust;

            Console.WriteLine("Sisestage palun oma eesnimi");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisestage arv '1' '2' või '3'");
            int userOperator = Convert.ToInt32(Console.ReadLine());
            switch (userOperator)
            {
                case 1:
                    ReverseName(userName);
                    break;

                case 2:
                    FirstLetter(userName);
                    break;
                case 3:
                    FirstNameLength(userName);
                    break;
                default:
                    Console.WriteLine("Sisestasite vale numbri! Kena päev!");
                    break;
            }
        }


        public static void ReverseName(string userInput)
        {
            for (int i = userInput.ToLower().Length - 1; i >= 0; i--)
            {
                
                Console.Write(userInput[i]);
            }
        }
        public static void FirstLetter(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }
        public static void FirstNameLength(string userInput)
        {
            Console.WriteLine($"sinu nimi on {userInput.Length} sümbolit pikk. ");
        }
    } 
 }
