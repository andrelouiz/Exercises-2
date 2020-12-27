using System;

namespace exercises
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //#1

            Console.WriteLine("Write an odd number: ");
            var num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Not an odd number.");

            }

            else Console.WriteLine("It's an odd number!");

            return();
            

            //#2
            
            Console.WriteLine("Enter a value for a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine( (a*b)/(a+b));

            //#3


            int i;
            int[] arr = new int[3];

            Console.WriteLine("Please write numbers to be sorted out: ");

            int numbers = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= numbers; i++)
            {
                Console.Write("Enter the No " + i + ":");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 1; i <= numbers; i++)
            {
                for (int j = 1; j <= numbers - 1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }

            }
            Console.Write("Ascending sort: ");
            for (i = 1; i <= numbers; i++)
            {
                Console.Write(arr[i] + " ");

            }


            //#4

            Start:

            Console.WriteLine("Starting magical calculator!");

            Console.WriteLine("Insert first number:");
            double numA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operator:");
            string operatorSignal = Console.ReadLine(); 

            Console.WriteLine("Insert first number:");
            double numB = Convert.ToDouble(Console.ReadLine());

            if (operatorSignal == "+")
            {
                Console.WriteLine(numA + numB);
            }

            else if (operatorSignal == "-")
            {
                Console.WriteLine(numA - numB);
            }

            else if (operatorSignal == "*")
            {
                Console.WriteLine(numA * numB);
            }

            else if (operatorSignal == "/")
            {
                Console.WriteLine(numA / numB);
            }
            else Console.Write("Invalid operation.");

            goto Start;

             #6
            StartFactorial:

                Console.WriteLine("Please write a number below 10 to be factored: ");
                int a = Int32.Parse(Console.ReadLine());
                Factorial(a);

                int fact = 1;
                for (int i = 1; i <= a; i++)
                {
                    fact *= i;
                }      

                Console.WriteLine(fact);

            goto StartFactorial;
                
            //#7 

            int i, j;
            for (i = 0; i <= 2; i++)
            {
                for (j = 1; j <= 6; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
          
            //#8

            int i, j, k;
            int x = 4; //# of lines

            for (i = 1; i <= x; i++)
            {
                //printing out spaces
                for (j = 1; j <= (x-i); j++)
                {
                    Console.Write(" ");
                }
                //printing out stars
                for (k = 1; k < i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
             

            //#9
            start:

            Console.Write("Write a number: ");
            int prime = Int32.Parse(Console.ReadLine());
            int count = 0;

            int i;


            for (i = 2; i <= (prime / 2); i++)
            {
                if (prime % i == 0)
                {
                    count = 1;
                    break;
                }
            }
            if (count == 1)
                Console.WriteLine("Number entered is not a prime!");
             else
                {
                    Console.Write("It's a prime.");
                }
            Console.WriteLine();

            goto start;
        
                

        }
    }
}

