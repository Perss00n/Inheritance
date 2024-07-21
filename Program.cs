using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Fido", 12, "Black", "Siberian Husky");
            Console.WriteLine($"This is my dog {dog.Name}! He is a {dog.Age} years old {dog.Color} {dog.Breed}.");
            dog.AnimalSound();

            Cat cat = new Cat("Missan", 8, "White", true);
            Console.WriteLine($"This is my cat {cat.Name}! He is a {cat.Age} years old {cat.Color} {(cat.IsIndoor ? "indoor" : "outdoor")} cat.");

            cat.AnimalSound();

            Console.ReadLine();
        }
    }

    class Animal
    {
        private string name;
        private int age;
        private string color;

        public Animal(string name, int age, string color)
        {
            this.Name = name;
            this.Age = age;
            this.Color = color;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
            }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound!");
        }
    }

    class Dog : Animal
    {
        private string breed;

        public Dog(string name, int age, string color, string breed) : base(name, age, color)
        {
            this.Breed = breed;
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public override void AnimalSound()
        {
            Console.WriteLine("Voff, Voff, Voff!");
        }
    }

    class Cat : Animal
    {
        private bool isIndoor;

        public Cat(string name, int age, string color, bool isIndoor) : base(name, age, color)
        {
            this.IsIndoor = isIndoor;
        }

        public bool IsIndoor
        {
            get { return isIndoor; }
            set { isIndoor = value; }
        }

        public override void AnimalSound()
        {
            Console.WriteLine("Meow, Meow, Meow!");
        }
    }
}