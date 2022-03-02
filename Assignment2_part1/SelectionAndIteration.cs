using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_part1
{
    class SelectionAndIteration
    {

        public SelectionAndIteration()
        {
            start();
        }

        private void start()
        {
            //mandatory setup
            Console.WriteLine();
            Console.WriteLine("My name is: Marcus and I am a student of VT 22");
            Console.WriteLine();

            //calling the ShowStringLength method
            ShowStringLength();
            //calling the MakeMyDay method
            MakeMyDay();
            //calling the SumNumbers method
            SumNumbers();
        }

        private void ShowStringLength()
        {
            //variables to be used in method.
            string text = "";
            bool done = false;

            Console.WriteLine("let me calculate the length of a string for you!");
            //do while to execute loop as long as string length is not 0
            do
            {
                Console.WriteLine("Give me a text of any length, or press Enter to exit!\n");
                text = Console.ReadLine();

                //getting length of user's text and setting done = true if this string is 0
                int length = text.Length;
                if (length == 0)
                {
                    done = true;
                } 
                //if length is not 0 we return the text capitalized and the amount of chars
                else
                {
                    text = text.ToUpper();
                    Console.WriteLine();
                    Console.WriteLine(text);
                    Console.WriteLine("Number of characters in text: "+text.Length+"\n");
                }
                //terminating loop
            } while (!done);
        }

        private void MakeMyDay()
        {
            int number = 0;

            Console.WriteLine("I can predict your day for you. Give me a number between 1 and 7:");

            //using a try-catch to catch wrong input formats (like a string) and restart the method
            try
            {
                int.TryParse(Console.ReadLine(), out number);
            }
            //specifically catching wrong format
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }
            //catching everything else.. mostly ints that are too big!
            catch (Exception)
            {
                Console.WriteLine("Error");
            }

            /*I did not add this initially, but when I hit an exception in my try-catch,
            it still executed my default clause in the switch and printed it out.
            I wanted to avoid this.*/
            if (1 <= number && number <= 7)
            {
                //making a switch with 7 cases, one for each number between 1 and 7
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Monday: Keep calm! You can fall apart!");
                        break;
                    case 2:
                    case 3:
                        Console.WriteLine("Tuesday and Wednesday break your heart!");
                        break;
                    case 4:
                        Console.WriteLine("Thursday, Uuush, still one day to Friday!");
                        break;
                    case 5:
                        Console.WriteLine("It's Friday! You are in love!");
                        break;
                    case 6:
                        Console.WriteLine("Saturday, do nothing and do plenty of it!");
                        break;
                    case 7:
                        Console.WriteLine("And Sunday always comes too soon!");
                        break;
                  
                    /*the default clause writes this part if none of the case conditions are fulfilled
                  I have kept the original default clause as a comment just to show what I thought of first */
                  
                    /*default:
                        Console.WriteLine("Not in a good mood? This is not between 1-7");
                        break;*/
                }
            } else
            {
                Console.WriteLine("The input is not valid. Try again.");
                Console.WriteLine();
                MakeMyDay();
            }
        }

        private void SumNumbers()
        {
            //making integer variables for getting user input and getting largest and lowest numbers
            int startNumber;
            int endNumber;
            int highestNumber;
            int lowestNumber;
            int sumTotal;

            //setting local variables to be equal to the method input
            Console.WriteLine();
            startNumber = startNumberInput();
            endNumber = endNumberInput();

            //if/else statement for determining which of the numbers is the biggest.
            if (startNumber > endNumber)
            {
                highestNumber = startNumber;
                lowestNumber = endNumber;
            } else
            {
                highestNumber = endNumber;
                lowestNumber = startNumber;
            }
            //calling the sumcalculator method and putting in our two determined variables
            sumTotal = sumcalculator(lowestNumber, highestNumber);
            //printing out the total sum
            Console.WriteLine("The sum of numbers between "+lowestNumber+" and "+highestNumber+" is: "+sumTotal);
        }

        private int startNumberInput()
        {
            int startNumber = 0;

            Console.WriteLine("Give a start number: ");
            /*the idea with spreading these two out in methods is to have error handling
            we are getting user input and returning it */
            try
            {
                /* I am aware of the A grade assignment with TryParse, so just left if here.
                I have  used this method in the other assignments but was playing with try-catch here
                */
                //int.TryParse(Console.ReadLine(), out startNumber);
                startNumber = int.Parse(Console.ReadLine());
                return startNumber;
            }
            //specifically catching wrong format
            catch (FormatException)
            {
                Console.WriteLine("This is the wrong format.. whole number, please!");
            }
            //catching everything else. Mostly ints that are too big
            catch (Exception)
            {
                Console.WriteLine("This is not right. Try again!");
            }
            //restarts the method if startNumber is not returned
            return startNumberInput();
        }

        private int endNumberInput()
        {
            int endNumber = 0;

            Console.WriteLine("Give an end number: ");
            /*the idea with spreading these two out in methods is to have error handling
            we are getting user input and returning it */
            try
            {
               /* I am aware of the A grade assignment with TryParse, so just left if here.
                I have  used this method in the other assignments but was playing with try-catch here
                */
                //int.TryParse(Console.ReadLine(), out endNumber);
                endNumber = int.Parse(Console.ReadLine());
                return endNumber;
            }
            //specifically catching wrong format
            catch (FormatException)
            {
                Console.WriteLine("This is the wrong format.. whole number, please!");
            }
            //catching everything else. Mostly ints that are too big
            catch (Exception)
            {
                Console.WriteLine("This is not right. Try again!");
            }
            //restarts the method if startNumber is not returned
            return endNumberInput();
        }

        private int sumcalculator(int firstNumber, int lastNumber)
        {
            int sum = 0;
            // making use of a for loop to get all numbers between lowest and highest amount
            //it is important to state that the calculation includes the numbers themselves - I am aware
            for (int i = firstNumber; i <= lastNumber; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}