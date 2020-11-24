using System;

namespace csharp_web_dev_studio1_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give us the radius of a circle");
            string radiusString = Console.ReadLine();
            double number;

            if (radiusString == "" || ! Double.TryParse(radiusString, out number))
            {
                Console.WriteLine("That does not work for the radius!");
                Environment.Exit(0);
            }
            
            double r = Double.Parse(radiusString);

            while (r < 0.0)
            {
                Console.WriteLine("You can't have a negative radius! Give it another try!");
                radiusString = Console.ReadLine();
                r = Double.Parse(radiusString);
            }

            double area = Math.PI * r * r;
            double circumference = Math.PI * 2 * r;
            double diameter = 2 * r;

            Console.WriteLine("The area of the circle is: " + area);
            Console.WriteLine("The circumference of the circle is: " + circumference);
            Console.WriteLine("The diameter of the circle is: " + diameter);

            Console.WriteLine("How many miles per gallon does your car get?");
            string mpgString = Console.ReadLine();
            double mpg = Double.Parse(mpgString);

            double gallonsUsed = circumference / mpg;
            Console.WriteLine("You need " + gallonsUsed + " gallons to travel around this circle");
        }
    }
}
