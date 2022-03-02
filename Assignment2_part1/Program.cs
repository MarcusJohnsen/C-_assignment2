using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining console look
            PrepareConsolesLook();

            //instantiating constructor object
            SelectionAndIteration select = new SelectionAndIteration();

            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();

            //instantiating constructor object
            TemperatureConverter temperatureConverter = new TemperatureConverter();

            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();

            //instantiating constructor object
            WorkingSchedule schedule = new WorkingSchedule(); 
        }

        //defining the console look
        static void PrepareConsolesLook()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Loops, for, switch";
        }
    }
}