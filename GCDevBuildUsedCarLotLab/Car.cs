using System;
using System.Collections.Generic;
using System.Text;

namespace GCDevBuildUsedCarLotLab
{
    class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public  double Price { get; set; }


        public Car()
        {
            
        }
        public Car(string Make, string Model, int Year, double Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
        }
        public override string ToString()
        {
            string output = $"Make: {Make, -13}\t";
            output += $"Model: {Model, -16}\t";
            output += $"Year: {Year,-5}\t";
            output += $"Price: {Price, -14:c}\t";

            return output;

        }
    }
}
