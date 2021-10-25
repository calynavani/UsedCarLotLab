namespace GCDevBuildUsedCarLotLab
{
    class UsedCars: Car
    {
        public double Mileage { get; set; }

        public UsedCars(string Make, string Model, int Year, double Price, double Mileage)
            :base(Make, Model, Year, Price)
        {
            this.Mileage = Mileage;
        }

        public override string ToString()
        {

            string output = base.ToString();
            
            output += $"USED Mileage: {Mileage, -2}";

            return output;


        }
    }
}
