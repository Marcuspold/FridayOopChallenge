using System;

namespace FridayOOPChallenge
{
    class Program
    {
        class Pet
        {
            string name;
            int age;
            double weight;
            double lifespan;

            public Pet(string _name)
            {
                name = _name;
                age = 0;
                weight = 0.1;
                lifespan = 0.1;
            }
            public string Name
            {
                get { return name;}
            }
            public int Age
            {
                get { return age; }
            }
            public double Weight
            {
                get { return weight; }
            }
            public double LifeSpan
            {
                get { return lifespan; }
            }
            public void Eat()
            {
                weight += 0.2;
            }
            public void excecise()
            {
                weight += 0.2;
            }
            public void ShowCatData()
            {
                Console.WriteLine($"Name: {name}; \n Age: {age}; \n Weight: {weight}; \n Lifespan: {lifespan}; ");
            }
        }
        class Cat
        {
            string name;
            string color;
            double hunger;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hunger = 0;
            }
            public string Name
            {
                get { return name; }
            }
            public string Color
            {
                get { return color; }
            }
            public double Hunger
            {
                get { return hunger; }
            }
            public void Sleep()
            {
                Console.WriteLine("I Always Sleep");
                hunger += 0.2;
            }
            public void Meow()
            {
                Console.WriteLine("Meow");
            }
            public void ShowPetDetails()
            {
                Console.WriteLine($"Name: {name}; \n Color: {color}; \n Hunger: {hunger}; \n");
            }
        }
        static void Main(string[] args)
        {
            Cat newCat = new Cat("Donny", "white");
            Console.WriteLine($"the happiness level {newCat.Hunger}");

            newCat.ShowPetDetails();
            while(newCat.Hunger != 1)
            {
                newCat.Sleep();
            }

            newCat.Meow();

            Pet newPet = new Pet("Ducky");

            newPet

        }
    }
}
