using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_part1
{
    class TemperatureConverter
    {
        public TemperatureConverter()
        {
            start();
        }

        private void start()
        {
            //less overcrowding
            Console.Clear();

            //solving this with a switch with 3 different cases
            int choice = -1;

            while(choice != 0)
            {
                //the shown menu
                ShowMenu();
                /*using TryParse for some error handling. I would have used try-catch like in 
                SelectionAndIteration, but I did it like this due to requirement. */
                int.TryParse(Console.ReadLine(), out choice);

                switch(choice)
                {
                    case 0:
                        break;
                    case 1:
                        //these two cases call one method for C to F, and one for F to C
                        ShowTableCelsiusToFahrenheit();
                        break;
                    case 2:
                        ShowTableFahrenheitToCelsius();
                        break;
                    default:
                        Console.WriteLine("this option is not valid!");
                        break;
                }
            }
        }

        private void ShowMenu()
        {
            //making the menu outlay
            Console.WriteLine("---------------------------------");
            Console.WriteLine("\n     TEMPERATURE CONVERTER       ");
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine("   Celsius to Fahrenheit    : 1");
            Console.WriteLine("   Fahrenheit to Celsius    : 2");
            Console.WriteLine("   Exit                     : 0");
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine(" Your choice:");
        }

        private void ShowTableCelsiusToFahrenheit()
        {
            const int columns = 2;
            const int max = 100;
            int p = 0;

            //the idea here is to run through all values between 0 and 100 with a spread of 4
            for (int i = 0; i <= max; i+=4)
            {
                //we then call the method that converts these C values to F
                double result = CelsiusToFahrenheit(i);
                //the formatted output in the Console
                Console.Write("{0,6:f2} C = {1,6:f2} F   ", i, result);

                //the idea here is to divide the output into two distinct columns for readability
                p++;
                if ((p % columns == 0) && (p>=columns))
                    Console.WriteLine();
            }
        }

        private void ShowTableFahrenheitToCelsius()
        {
            const int columns = 2;
            const int max = 212;
            int p = 0;

            //the idea here is to run through all values between 0 and 100 with a spread of 4
            for (int i = 0; i <= max; i += 10)
            {
                //we then call the method that converts these C values to F
                double result = FahrenheitToCelsius(i);
                //the formatted output in the Console
                Console.Write("{0,6:f2} F = {1,6:f2} C   ", i, result);

                //the idea here is to divide the output into two distinct columns for readability
                p++;
                if ((p % columns == 0) && (p >= columns))
                    Console.WriteLine();
            }
        }

        private double CelsiusToFahrenheit(double celsius)
        {
            /*simply does the math for conversion..
            0 celsius is 32 fahrenheit, and then 1 celsius = 1,8 fahrenheit.*/
            return 9.0 / 5.0 * celsius + 32;
        }

        private double FahrenheitToCelsius(double fahrenheit)
        {
            /*simply does the math for conversion..
            1 fahrenheit is .55 celsius and then considers the -32 for the freezing point*/
            return 5.0 / 9.0 * (fahrenheit - 32);
        }
    }
}
