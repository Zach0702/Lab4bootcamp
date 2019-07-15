using System;

namespace Lab4BTC
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            string userNumber; //user entry
            bool isInValidInput = true;
            int validInt = 0;  //int confirmer
            char loopBreaker;

            //Asking user to enter an integer

            while (isInValidInput)
            {
                Console.WriteLine("Please enter an integer: ");
                userNumber = Console.ReadLine();

                if(int.TryParse(userNumber, out validInt))
                {
                    isInValidInput = false;
                }
                else
                {
                    Console.WriteLine("ERROR: invalid entry, please enter again");
                }
            }

            //table
            Console.WriteLine("Number       Squared        Cubed");
            Console.WriteLine("------       -------        -----");
            for (int i = 1; i <= validInt; i++)
            {
                Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", i, i*i, i*i*i));
            }

            Console.WriteLine();
            Console.WriteLine("Do you wish to continue? (enter y or n)");
            loopBreaker = char.Parse(Console.ReadLine());

            while (loopBreaker == 'y')
            {
                isInValidInput = true;
                while (isInValidInput)
                {
                    Console.WriteLine("Please enter an integer: ");
                    userNumber = Console.ReadLine();

                    if (int.TryParse(userNumber, out validInt))
                    {
                        isInValidInput = false;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: invalid entry, please enter again");
                    }
                }

                //table
                Console.WriteLine("Number       Squared        Cubed");
                Console.WriteLine("------       -------        -----");
                for (int i = 1; i <= validInt; i++)
                {
                    Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", i, i * i, i * i * i));
                }

                Console.WriteLine();
                Console.WriteLine("Do you wish to continue? (enter y or n)");
                loopBreaker = char.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("End of application!");
            Console.ReadLine();


        }
    }
}
