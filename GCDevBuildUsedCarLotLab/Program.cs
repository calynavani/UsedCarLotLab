using System;

namespace GCDevBuildUsedCarLotLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //make an object of CarLot
            bool goOn = true;
            
                CarLot carlot = new CarLot();
                Console.WriteLine("Welcome To Calyn's Gently Used CarLot");
                Console.WriteLine();
                carlot.ListCars();
            Console.WriteLine();
            while (goOn)
            {

                carlot.RemoveCar();
                carlot.ListCars();
                Console.Write("Would you like to add a car of your dreams? Enter [yes] or [no]");
                string userAnswer = Console.ReadLine();
                Console.WriteLine();
                while (userAnswer != "yes" && userAnswer != "no")
                {
                    Console.WriteLine("That was an invlaid answer");
                    Console.WriteLine("Try again!");
                    Console.Write("Would you like to add a car of your dreams? Enter [yes] or [no]");
                    userAnswer = Console.ReadLine();
                }
                if (userAnswer == "yes")
                {
                    carlot.AddCar();
                }
                Console.Write("Would you like to continue? Enter [yes] or [no]: ");
                string userAnswer3 = Console.ReadLine().ToLower();
                Console.WriteLine();
                while (userAnswer != "yes" && userAnswer != "no")
                {
                    Console.WriteLine("That was an invlaid answer");
                    Console.WriteLine("Try again!");
                    Console.Write("Would you like to add a car of your dreams? Enter [yes] or [no]");
                    userAnswer3 = Console.ReadLine().ToLower();
                }
                if (userAnswer == "no")
                {
                    Console.WriteLine("Thank you come again!");
                    goOn = false;
                    break;
                }


                Console.WriteLine();
                carlot.ListCars();

                Console.Write("Would you like to continue? Enter [yes] or [no]: ");
                string userAnswer2 = Console.ReadLine().ToLower();
                Console.WriteLine();
                while (userAnswer != "yes" && userAnswer != "no")
                {
                    Console.WriteLine("That was an invlaid answer");
                    Console.WriteLine("Try again!");
                    Console.Write("Would you like to add a car of your dreams? Enter [yes] or [no]");
                    userAnswer2 = Console.ReadLine().ToLower();
                }
                if (userAnswer == "no")
                {
                    Console.WriteLine("Thank you come again!");
                    goOn = false;
                    break;
                }
            }

        }

      
    }
}
