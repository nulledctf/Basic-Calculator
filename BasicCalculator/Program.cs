using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1; //Set variables for first number
            int num2; //Set variables for second number

            string answer;

            int result;

            Console.WriteLine("Welcome To BasicCalculator");  //Greet message

            Console.WriteLine("First Number: ");            
            num1 = Convert.ToInt32(Console.ReadLine());   
           
            Console.WriteLine("Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick your operation: ");

            Console.WriteLine("1 For addition, 2 for subtraction, 3 for Multiplication, 4 for Division");
            
            answer = Console.ReadLine();

            if (answer == "1")
            {
                result = num1 + num2;
            }
            else if (answer == "2")
            {
                result = num1 - num2;
            }
            else if (answer == "3")
            {
                result = num1 * num2;
            }
            else 
            {
                result = num1 / num2;
            }

            Console.WriteLine("Your answer is " + result);

            Console.ReadKey();
        }
    }
}
