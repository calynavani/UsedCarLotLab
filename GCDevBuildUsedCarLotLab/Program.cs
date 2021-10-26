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
            CarLotApp app = new CarLotApp();
            Console.WriteLine("***Welcome To Calyn's Gently Used CarLot***\t\t");
            Console.WriteLine();
            Console.WriteLine("Featuring CGGC's New Mobile App!!!!");
            Console.WriteLine();
            Console.Write("Would you like to use it? Enter [yea] or [no]: ");
            string a = Console.ReadLine().ToLower();
            while(a != "yes" && a != "no")
            {
                Console.WriteLine("That was an invalid answer.");
                Console.WriteLine("Please try again.");
                Console.Write("Would you like to use it? Enter [yes] or [no]: ");
                a = Console.ReadLine().ToLower();
            }
            if(a == "yes")
            {
               
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                app.DisplayApp();
            }
            if(a == "no")
            {
                Console.WriteLine("You are now being redirected to the website.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }



            while (goOn)
            {


                Console.WriteLine("Welcome To Calyn's Gently Used CarLot");
                Console.WriteLine();
                carlot.ListCars();
                Console.WriteLine();
           
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
                if(userAnswer == "yes")
                {
                    goOn = true;
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
