using System;

namespace Inheritance
{
    // Base class
    class Animal
    {
        public string name;

        // Constructor
        public Animal()
        {
            name = "";
        }

        // Parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        // Method to display animal information
        public void Display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }
    }

    // Second derived class
    class AnimalInfo : Animal
    {
        // Additional public fields
        public double Height;
        public double Weight;
        public int Age;

        // Default constructor
        public AnimalInfo()
        {
            Height = 0.0;
            Weight = 0.0;
            Age = 0;
        }

        // Parameterized constructor
        public AnimalInfo(string name, double height, double weight, int age) : base(name)
        {
            Height = height;
            Weight = weight;
            Age = age;
        }

        // Method to display animal information
        public void DisplayAnimalInfo()
        {
            Console.WriteLine($"Name: {name}, Height: {Height} cm, Weight: {Weight} kg, Age: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the number of animals
            Console.Write("Enter the number of animals: ");
            int numAnimals = int.Parse(Console.ReadLine());

            // Loop through each animal
            for (int i = 0; i < numAnimals; i++)
            {
                Console.WriteLine($"\nEnter details for Animal {i + 1}");

                // Get input for animal details
                Console.Write("Enter the animal's name: ");
                string animalName = Console.ReadLine();

                Console.Write("Enter the animal's height (in cm): ");
                double animalHeight = double.Parse(Console.ReadLine());

                Console.Write("Enter the animal's weight (in kg): ");
                double animalWeight = double.Parse(Console.ReadLine());

                Console.Write("Enter the animal's age: ");
                int animalAge = int.Parse(Console.ReadLine());

                // Create an AnimalInfo object with the provided details
                AnimalInfo userAnimal = new AnimalInfo(animalName, animalHeight, animalWeight, animalAge);

                // Display the animal information
                userAnimal.Display();
                userAnimal.DisplayAnimalInfo();
            }
        }
    }
}
