using System;

namespace UserNameData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm kuvab kasutaja eesnime pikkust 
            //programm kuvab eesnime esimest tähte
            //programm kuvab kasutaja eesnime tagurpidi
            //main meetoodis ei tohi olle rohkem, kui kolm rida koodi
            Console.WriteLine("Sisestage palun oma eesnimi");
            string userName = Console.ReadLine();
            GetUserNameData(userName);
        }

        public static void GetUserNameData(string userInput)
        {
            Console.WriteLine($"sinu nimi on {userInput.Length} sümbolit pikk. ");
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");

            for(int i = userInput.Length -1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }    

        }
    }
}
