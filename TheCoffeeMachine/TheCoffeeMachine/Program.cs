using System;

namespace TheCoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeePowder coffee = new CoffeePowder(100);
            WaterGalon water = new WaterGalon(1000);
            CoffeeMilk milk = new CoffeeMilk(400);
            CoffeeMachine yummyCoffee = new CoffeeMachine(coffee, water, milk);

            Console.WriteLine("The Coffee Machine!");
            Console.WriteLine("Pilihan : ");
            Console.WriteLine("A. Espresso");
            Console.WriteLine("B. Cappucino");
            Console.WriteLine("Pilihan Salah Satu : ");  

            char order = char.Parse(Console.ReadLine());

            if (order == 'a')
            {
                Console.WriteLine("\ncheck " + yummyCoffee.checkAvailability());
                String result = yummyCoffee.makeEsspresso();
                Console.WriteLine("result " + result);
            }

            if (order == 'b')
            {
                Console.WriteLine("\ncheck " + yummyCoffee.checkAvailability());
                String result = yummyCoffee.makeCappucino();
                Console.WriteLine("result " + result);
            }

            Console.WriteLine("check " + yummyCoffee.checkAvailability());

        }
    }
}
