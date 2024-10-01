using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_DesignPattern
{
    public abstract class Car
    {
        protected int basePrice = 0, onRoadPrice = 0;
        public string ModelName { get; set; }
        public int BasePrice
        {
            set => basePrice = value;
            get => basePrice;
        }
        public int OnRoadPrice
        {
            set => onRoadPrice = value;
            get => onRoadPrice;
        }
        public static int SetAdditionalPrice()
        {
            Random random = new Random();
            int additonalPrice = random.Next(200_000, 500_000);
            return additonalPrice;
        }
        public abstract Car Clone();
    }// end Car

    public class Mustang : Car
    {
        public Mustang(string model) => (ModelName, BasePrice) = (model, 200_000);
        //creating shallow copy and return it
        public override Car Clone()
        => this.MemberwiseClone() as Mustang;
    }// end Mustang

    public class Bentley : Car
    {
        public Bentley(string model) => (ModelName, BasePrice) = (model, 300_000);
        //creating shallow copy and return it
        public override Car Clone()
        => this.MemberwiseClone() as Bentley;
    }// end Mustang
    internal class Demo_PrototypePattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Prototype Pattern Demo***\n");

            Car mustang = new Mustang("Muustang EcoBoost");
            Car bentley = new Bentley("Continental GT Mulliner");

            Console.WriteLine($"Car is: {mustang.ModelName}, and it's base price is Rs. {mustang.BasePrice}");
            Console.WriteLine($"Car is: {bentley.ModelName}, and it's base price is Rs. {bentley.BasePrice}");

            Car Car;
            Car = mustang.Clone();
            Car.OnRoadPrice = Car.BasePrice + Car.SetAdditionalPrice();
            Console.WriteLine($"Car is: {Car.ModelName}, and it's price is Rs. {Car.OnRoadPrice}");

            Car = bentley.Clone();
            Car.OnRoadPrice = Car.BasePrice + Car.SetAdditionalPrice();
            Console.WriteLine($"Car is: {Car.ModelName}, and it's price is Rs. {Car.OnRoadPrice}");
            Console.ReadLine();
        }
    }
}
