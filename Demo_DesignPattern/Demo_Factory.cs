using System.Collections.Generic;
using static System.Console;// using static directive

namespace Demo_DesignPattern
{

    public interface IAnimal
    {
        void AboutMe();
    }

    //Lion class
    public class Lion : IAnimal
    {
        public void AboutMe() => WriteLine("This is Lion.");
    }

    //Tiger class
    public class Tiger : IAnimal
    {
        public void AboutMe() => WriteLine("This is Tiger.");
    }

    public abstract class AnimalFactory
    {
        public abstract IAnimal CreateAnimal();
    }

    public class LionFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal() => new Lion();
    }


    public class TigerFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal() => new Tiger();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Factory Method Pattern Demo.***\n");
            List<AnimalFactory> animalFactorieList = new List<AnimalFactory>()
            {
                new TigerFactory()
                ,new LionFactory()
            };
            foreach (var animal in animalFactorieList)
            {
                animal.CreateAnimal().AboutMe();
            }
            ReadLine();
        }
    }
}