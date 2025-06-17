using System.Xml.Serialization;

namespace _3U_Methods
{
    // Enter code here
    internal class Program
    {
        static void Main(string[] args)
        {
            double itemPrice = 100;
            double tax = calculateTax(itemPrice);
            Console.WriteLine("Tax is: $" + tax);
        }

        public static double Square(double number)
        {
            return number * number;
        }


        public static void DrawCheck()
        {
            Console.WriteLine("     /");
            Console.WriteLine("    /");
            Console.WriteLine("\\  /"); // Since '\' is a special character, we must use two of them to print one
            Console.WriteLine(" \\/");
        }

        public static void DrawX()
        {
            Console.WriteLine("\\  /");
            Console.WriteLine(" \\/");
            Console.WriteLine(" /\\"); // Since '\' is a special character, we must use two of them to print one
            Console.WriteLine("/  \\");
        }

        public static void DrawCircle()
        {
            Console.WriteLine("  ___  ");
            Console.WriteLine(" /   \\ ");
            Console.WriteLine("|     |");
            Console.WriteLine(" \\___/ ");
        }
        public static void DrawSquare()
        {
            Console.WriteLine("_____");
            Console.WriteLine("|   | ");
            Console.WriteLine("|___| ");
        }
        public static double calculateTax(double price)
        {
            const double taxRate = 0.13;
            return price * taxRate;
        }

        public static double FinalPrice(double price)
        {
            return price + calculateTax(price); // This method is simple enough that you could just calclate the tax directly here, but it's better to keep it separate for clarity and reusability.
        }

        public static double CircleCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

    }
}
