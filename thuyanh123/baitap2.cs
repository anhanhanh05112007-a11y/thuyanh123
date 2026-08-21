

namespace CSLT.session02
{
    internal class exercisec_1
    {
        public static void Main(string[] args)
        {
            int number1 = 20, number2 = 15;
            //1. to Add / Sum Two Numbers.
            int sum = number1 + number2;
            Console.WriteLine($"1.{number1} +{number2} ={sum}");

            //2. to Swap Values of Two Variables.
            int temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine($"2.After swap number1={number2}, number 2{number1}");

            //3. to Multiply two Floating Point Numbers
            float f1 = 8.74f, f2 = 5.6f;
            float f3 = f1 * f2;
            Console.WriteLine($"3.{f1} * {f2} = {f3}");

            //4. to convert feet to meter
            float feet = 3.5f;
            float meter = feet * 0.3048f;
            Console.WriteLine($"4.{feet} feet= {meter} meter");

            //5. to convert Celsius to Fahrenheit and vice versa
            float celsius = 25f;
            float fah = celsius * 1.8f + 32;
            Console.WriteLine($"5.{celsius}°C = {fah}°F");

            //6. to find the Size of data types
            Console.WriteLine($"6.Size of double data type is {sizeof(double)} bytes");
            Console.WriteLine($"  Size of float data type is {sizeof(float)} bytes");
            Console.WriteLine($"  Size of int data type is {sizeof(int)} bytes");
            Console.WriteLine($"  Size of char data type is {sizeof(char)} bytes");

            //7. to Print ASCII Value (tip: read character, print number of this char)
            Console.WriteLine("7.Enter a character:");
            int c = Console.Read();
            Console.WriteLine($"ASCII code of {(char)c} is {c}");

            //8. to Calculate Area of Circle
            float R = 4.5f;
            float areaC = (float)Math.PI * R * R;
            Console.WriteLine($"8.Area of circle with radius {R} = {areaC}");
            //9. to Calculate Area of Square

            float side = 6.2f;
            float areaS = side * side;
            Console.WriteLine($"9.Area of square with side {side} = {areaS}");

            //10. to convert days to years, weeks and days
            int d = 541;
            int years = d / 365;
            int weeks = (d % 365) / 7;
            int days = (d % 365) % 7;
            Console.WriteLine($"10.{d} days= {years} years, {weeks} weeks, {days} days");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }

    }
}