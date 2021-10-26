using System;
using System.Collections.Generic;
using System.Text;

namespace GCDevBuildUsedCarLotLab
{
    class CarLotApp: Car
    {




        public CarLotApp()
            
        {
            

           

            


        }

        public void DisplayApp()
        {
            CarLot carlot = new CarLot();
            List<string> menu = new List<string>();
            menu.Add("View Inventory");
            menu.Add("Buy A Car ");
            menu.Add("List A Car");
            menu.Add("Quit");


            
            Console.WriteLine("*****************CGUC****************\t\t");
            Console.WriteLine();
            Console.WriteLine("Welcome, I hope you're having a blessed day!\t\t");
            Console.WriteLine();
            Console.Write("what would you like to do? ");
            Console.WriteLine();
            for (int i = 0; i < menu.Count; i++)
            {
                Console.WriteLine($"{i + 1} {menu[i]}");
            }
            Console.WriteLine();
            
            int userAnswer = int.Parse(Console.ReadLine());

            switch (userAnswer)
            {
                case 1:
                    carlot.ListCars();

                    break;
                case 2:
                    carlot.GetType();
                    break;

                case 3:
                    
                    carlot.AddCar();
                    break;

                case 4:
                    Console.WriteLine("Have a Blessed Day! <3");
                    Console.WriteLine("You are now being redirected to the website.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    break;

            }

           
 
        }
    }


}
