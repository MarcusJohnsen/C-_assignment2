using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_part1
{
    class WorkingSchedule
    {
        public WorkingSchedule()
        {
            start();
        }

        private void start()
        {
            //less overcrowding
            Console.Clear();

            //I chose to do this part the same way we did in the TemperatureConverter
            int choice = -1;

            while (choice != 0)
            {
                ShowMenu();
                /*using TryParse for some error handling. I would have used try-catch like in 
                SelectionAndIteration, but I did it like this due to requirement. */
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 0:
                        break;
                    case 1:
                        /*these two cases call the same method, but with the boolean values
                        "true" or "false" to determine which of the two schedules are being shown
                        */
                        showSchedule(true);
                        break;
                    case 2:
                        showSchedule(false);
                        break;
                    default:
                        Console.WriteLine("this option is not valid!");
                        break;
                }
            }
        }

        private void ShowMenu()
        {
            //basic setup
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1 Show a list of the weekends to work.");
            Console.WriteLine("2 Show a list of the nights to work.");
            Console.WriteLine("0 Exit");
            Console.WriteLine("\nYour choice:");
        }

        /*I have chosen to solve the problem like this: Using a boolean in an if-statement
        to determine whether we want the weekend or night schedule shown.
        What I initially wanted was to make a for loop with placeholder values, but I
        did not discover a way to do this; if it is even possible.
        */
        private void showSchedule(bool weekendSchedule)
        {
            const int columns = 4;
            const int maxWeek = 52;
            int p = 0;

            if (weekendSchedule)
            {
                /* I furthermore chose to up a for loop, like the Temperature solution.
                This due to the fact that the know the interval we want to use,
                and thus exactly how many values and when we want the iteration to stop.
                For that reason, I saw a for loop as the best approach.
                 */
                for (int i = 2; i <= maxWeek; i += 3)
                {
                    Console.Write("      Week{0,3:f0}   ", i);

                    p++;
                    if ((p % columns == 0) && (p >= columns))
                        Console.WriteLine();
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 1; i <= maxWeek; i += 4)
                {
                    Console.Write("      Week{0,3:f0}   ", i);

                    p++;
                    if ((p % columns == 0) && (p >= columns))
                        Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
