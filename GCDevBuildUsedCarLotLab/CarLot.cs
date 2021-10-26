using System;
using System.Collections.Generic;
using System.Text;

namespace GCDevBuildUsedCarLotLab
{
    class CarLot
    {
        Car car = new Car();
        List<Car> Cars { get; set; } = new List<Car>();
        public CarLot()
        {
            Cars.Add(new NewCars("Telsa", "X", 2021, 79990.00));
            Cars.Add(new NewCars("Lamborghini", "Huracan", 2021, 212266.00f));
            Cars.Add(new NewCars("GMC Sierra", "3500 HD Denali", 2022, 67200.00f));
            Cars.Add(new UsedCars("Ponitac", "GT G6", 2006, 3870.00, 250000.00f));
            Cars.Add(new UsedCars("Volkswagen", "Beetle", 2007, 5000.00, 80000.00f));
            Cars.Add(new UsedCars("Fiat", "500X", 2018, 32000.00, 60000.00f));
        }

        public void AddCar()
        {
            Console.Write("Would you like to add a used car? or a new car? Enter [used] or [new]");
            string userCarType = Console.ReadLine().ToLower();
            while(userCarType == "used")
            {
               
                Console.Write("Enter the Make of the Car: ");
                string userAddMake1 = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter the Model: ");
                string userAddModel1 = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter the Year of the Car: ");
                int userAddYear1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Enter the Price of the Car:");
                double userAddPrice1 = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Enter the Mileage of the Car: ");
                double userAddMileage1 = double.Parse(Console.ReadLine());
                Cars.Add(new UsedCars(userAddMake1, userAddModel1, userAddYear1, userAddPrice1, userAddMileage1));


                return;
            }
            Console.Write("Enter the Make of the Car: ");
            string userAddMake = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter the Model: ");
            string userAddModel = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter the Year of the Car: ");
            int userAddYear = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the Price of the Car:");
            double userAddPrice =double.Parse(Console.ReadLine());
            Console.WriteLine();
          
            Cars.Add(new NewCars(userAddMake, userAddModel, userAddYear, userAddPrice));

            ListCars();

        }
        

        public void ListCars()
        {
           for(int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine($"{i + 1} {Cars[i]}");
            }

        }
        
        public void RemoveCar()
        {
            Console.Write("What car are you wanting to splurge on? ");
            int userRemoveCar = int.Parse(Console.ReadLine());
           
            Console.WriteLine($"This {Cars[userRemoveCar - 1].Make} is yours :D");
            Console.WriteLine("Please enter your email address: ");
            string userEmail = Console.ReadLine();
            Console.WriteLine($"Thank you we will send you invoice to: {userEmail}");
            Console.WriteLine();
            Cars.RemoveAt(userRemoveCar - 1);

        }

    }

}
