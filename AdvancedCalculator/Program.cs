using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    class Program
    {
        //Declaring global variables
        const int Addition = 1;
        const int Subtraction = 2;
        const int Multiplication = 3;
        const int Division = 4;
        const int Power = 5;
        const int Exit = 6;
        static float numberOne;
        static float numberTwo;
        static float numberAnswer;

        static void Main(string[] args)
        {
            //Declaring variables
            int operationFlag;
            bool backToMenu = true;

            //Setting program to repeat until user quits
            do
            {
                Console.Clear();

                //Displaying menu
                Console.WriteLine("Please enter the number for the operation you would like to perform.");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Power");
                Console.WriteLine("6. Exit Application");

                //Reading input and checking if it's an integer
                operationFlag = GiveMeAInt();

                //Checking if input was an integer 1-6, and performing relevant operations
                if (operationFlag > 0 && operationFlag < 7)
                {
                    switch (operationFlag)
                    {
                        case Addition:
                            DoAddition(); //Calling addition method
                            break;
                        case Subtraction:
                            DoSubtraction(); //Calling subtraction method
                            break;
                        case Multiplication:
                            DoMultiplication(); //Calling multiplication method
                            break;
                        case Division:
                            DoDivision(); //Calling division method
                            break;
                        case Power:
                            DoPower(); //Calling power method
                            break;
                        case Exit:
                            backToMenu = false; //setting the bool to end the program
                            break;
                    }
                }
                else //Menu error handling
                {
                    Console.WriteLine("Please select a valid option!");
                    Console.ReadLine();
                }
            } while (backToMenu);
        }

        //Method that performs addition with requested inputs
        static void DoAddition()
        {
            //Clearing menu from screen
            Console.Clear();

            numberOne = GiveMeAFloat();
            numberTwo = GiveMeAFloat();
            numberAnswer = numberOne + numberTwo;

            //Printing equation to screen
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(numberOne + " + " + numberTwo + " = " + numberAnswer);

            Console.ReadLine();
        }

        static void DoSubtraction()
        {
            //Clearing menu from screen
            Console.Clear();

            numberOne = GiveMeAFloat();
            numberTwo = GiveMeAFloat();
            numberAnswer = numberOne - numberTwo;

            //Printing equation to screen
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(numberOne + " - " + numberTwo + " = " + numberAnswer);

            Console.ReadLine();
        }

        static void DoMultiplication()
        {
            //Clearing menu from screen
            Console.Clear();

            numberOne = GiveMeAFloat();
            numberTwo = GiveMeAFloat();
            numberAnswer = numberOne * numberTwo;

            //Printing equation to screen
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(numberOne + " * " + numberTwo + " = " + numberAnswer);

            Console.ReadLine();
        }

        static void DoDivision()
        {
            bool zeroDenominator = true;
            //Clearing menu from screen
            Console.Clear();

            numberOne = GiveMeAFloat();

            do
            {
                numberTwo = GiveMeAFloat();
                if (numberTwo == 0)
                {
                    Console.WriteLine("You can't divide by 0!");
                }
                else
                {
                    numberAnswer = numberOne / numberTwo;
                    zeroDenominator = false;
                }
            } while (zeroDenominator);

            //Printing equation to screen
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(numberOne + " / " + numberTwo + " = " + numberAnswer);

            Console.ReadLine();
        }

        static void DoPower()
        {
            int powerNum;

            //Clearing menu from screen
            Console.Clear();

            numberOne = GiveMeAFloat();

            Console.WriteLine("The power must be an integer.");
            powerNum = GiveMeAInt();

            //Beginning power multiplication
            if (powerNum != 0)
            {
                numberAnswer = numberOne;

                for (int i = 0; i < powerNum - 1; i++)
                {
                    numberAnswer *= numberOne;
                }
            }
            else  //Accounting for special case of the power being 0
            {
                numberAnswer = 1;
            }

            //Printing equation to screen
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(numberOne + " ^ " + powerNum + " = " + numberAnswer);

            Console.ReadLine();
        }

        static float GiveMeAFloat()
        {
            bool isValid = false;
            float userNumber = 0;

            do
            {
                Console.WriteLine("Give me a number.");
                isValid = float.TryParse(Console.ReadLine(), out userNumber);

                if (!isValid)
                {
                    Console.WriteLine("That's not even a number!");
                    Console.ReadLine();
                }
            } while (!isValid);


            return userNumber;
        }

        static int GiveMeAInt()
        {
            bool isValid = false;
            int userNumber = 0;

            do
            {
                Console.WriteLine("Pick the number you'd like.");
                isValid = int.TryParse(Console.ReadLine(), out userNumber);

                if (!isValid)
                {
                    Console.WriteLine("That's not a valid number!");
                    Console.ReadLine();
                }
            } while (!isValid);


            return userNumber;
        }
    }
}
