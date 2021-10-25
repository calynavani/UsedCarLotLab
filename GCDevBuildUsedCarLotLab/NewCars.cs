using System;
using System.Collections.Generic;
using System.Text;

namespace GCDevBuildUsedCarLotLab
{
    class NewCars: Car
    {
        public NewCars(string Make, string Model, int Year, double Price)
            : base (Make, Model, Year, Price)
        {

        }

        public override string ToString()
        {

            string output = base.ToString();

            
            output += $"Price: {Price -2}";
           

            return output;


        }
    }
}
