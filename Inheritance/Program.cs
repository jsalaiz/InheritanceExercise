using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var redTailedHawk = new Bird()
            {
                LifespanInYears = 13,
                NumberOfLegs = 2,
                Color = "Brown",
                GiveBirthToLiveYoung = false,
                WingSpanInFeet = 4,
                PoopsOnCars = true
            };

            Console.WriteLine($"{redTailedHawk.GetType().Name}");
            Console.WriteLine($"Lifespan In Years: {redTailedHawk.LifespanInYears}");
            Console.WriteLine($"Number of Legs: {redTailedHawk.NumberOfLegs}");
            Console.WriteLine($"Color: {redTailedHawk.Color}");
            Console.WriteLine($"Give Birth to Live Young: {redTailedHawk.GiveBirthToLiveYoung}");
            Console.WriteLine($"Wingspan in Feet: {redTailedHawk.WingSpanInFeet}");
            Console.WriteLine($"Poops on Cars: {redTailedHawk.PoopsOnCars}");
            Console.WriteLine("");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var Anaconda = new Reptile()
            {
                LifespanInYears = 10,
                NumberOfLegs = 0,
                Color = "Green",
                GiveBirthToLiveYoung = false,
                HasScalySkin = true,
                IsColdBlooded = true
            };

            Console.WriteLine($"{Anaconda.GetType().Name}");
            Console.WriteLine($"Lifespan In Years: {Anaconda.LifespanInYears}");
            Console.WriteLine($"Number of Legs: {Anaconda.NumberOfLegs}");
            Console.WriteLine($"Color: {Anaconda.Color}");
            Console.WriteLine($"Give Birth to Live Young: {Anaconda.GiveBirthToLiveYoung}");
            Console.WriteLine($"Has Scaly Skin: {Anaconda.HasScalySkin}");
            Console.WriteLine($"Is Cold-Blooded: {Anaconda.IsColdBlooded}");
        }
    }
}
