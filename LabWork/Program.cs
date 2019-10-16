using System;

namespace LabWork
{
    class Program
    {
        static void Main(string[] args)
        {
            String num1, num2;
            int iNum1, iNum2 , result;
          
            char ch;
            Console.WriteLine("Enter Number 1 ");
           num1=  Console.ReadLine();
            iNum1 = Convert.ToInt32(num1);
            Console.Clear();

            Console.WriteLine("Enter Number 2 ");
            num2 = Console.ReadLine();
            iNum2 = Convert.ToInt32(num2);
            Console.Clear();

            Console.WriteLine("Enter Any Operator");
            ch=  Console.ReadKey().KeyChar;
            Console.Clear();

            if (ch == '+')
            {
                result = iNum1 + iNum2;

                Console.WriteLine("\nResult is " + result);
            }
            else if(ch== '-')
            {
                result = iNum1 - iNum2;

                Console.WriteLine("\nResult is " + result);
            }
            else if (ch == '*')
            {
                result = iNum1 * iNum2;

                Console.WriteLine("\nResult is " + result);
            }
            else if (ch == '/')
            {
                result = iNum1 / iNum2;

                Console.WriteLine("\nResult is " + result);
            }
            else
            {
                Console.WriteLine("Something Went Wrong");
            }


        }
    }
}
