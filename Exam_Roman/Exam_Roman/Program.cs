using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Roman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
           GetMyInfo("Roman Islam Ratul");
            SolutionProblem2("THIS IS AN EXAMPLE");
            SolutionProblem3(10);
            SolutionProblem4(1);
            SolutionProblem5(1,1);
            SolutionProblem6();
            SolutionProblem7(-2);
            SolutionProblem8();
            SolutionProblem9();
            SolutionProblem10();
            Console.ReadKey();
        }
        static void GetMyInfo(string name)
        {
            try
            {
                {

                    string myname = "Roman Islam Ratul";

                    Console.WriteLine(myname + " " + DateTime.Now);


                }
                Console.WriteLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occured.");
            }
        }
        static void SolutionProblem2(string input)
        {
            try
            {
                string text = "";
                text = input.ToString();

                Console.WriteLine("Numbers of text: " + text.Length);

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured.");
            }
            Console.WriteLine();
        }
        static void SolutionProblem3(int input)
        {
            try
            {
                string output;
                if(input % 2 == 0)
                {
                    output = ("EVEN");
                }
                else
                {
                    output = ("ODD");
                }
                Console.WriteLine(input + " is " + output.ToString());
                Console.WriteLine();
            }
            

            catch(Exception ex)
            {
                Console.WriteLine("An error occured.");
            }
        }

        static void SolutionProblem4(int input)
        {
            try
            {
                for (int i = 1; i <= 10; i++)

                {

                    Console.Write(" " + i);

                }
                Console.WriteLine();
                Console.WriteLine();
                
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occured.");
            }
        }

        static void SolutionProblem5(int val1, int val2)
        {
            try
            {
                int result = 0;

                Console.WriteLine("Insert first value: ");

                 val1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insert second value: ");

                val2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose an operation ' + ' or ' x ': ");

                string oper = Console.ReadLine();



                if (oper == "+")

                {

                    result = val1 + val2;

                    Console.WriteLine(val1 + " + " + val2 + " = " + result);

                    Console.ReadKey();

                    Console.Clear();

                }

                else if (oper == "*")

                {

                    result = val1 * val2;

                    Console.WriteLine(val1 + " x " + val2 + " = " + result);

                    Console.ReadKey();

                 
                }

                
                Console.Write("Your operation: " + "" + val1 + "/" + val2 + "/" + oper);
                Console.WriteLine();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured.");
            }
            Console.WriteLine();
        }

        static void SolutionProblem6()
        {
            try
            {
                Console.WriteLine("Insert Month (1 - 12): ");

                int month = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insert Day (1 - 31): ");

                int day = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insert Year (1 - 9999): ");

                int year = Convert.ToInt32(Console.ReadLine());
                                
                Console.Write("Your date: " + "" + month + "/" + day + "/" + year);
                                
                DateTime dateValue = new DateTime(year, month, day);

                Console.WriteLine(" is: " + " " + dateValue.ToString("dddd"));
                                                
                Console.ReadKey();
                             
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured.");
            }

        }
             
     
        static void SolutionProblem7(int input)
        {
            try
            {
                if(input > 0)
                {
                    Console.WriteLine(input.ToString() + " is POSITIVE");
                }
                if(input == 0)
                {
                    Console.WriteLine("This is zero");
                }
                if(input < 0)
                {
                    Console.WriteLine(input.ToString() + " is NEGATIVE");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occured.");
              
            }
         
        }

        static void SolutionProblem8()
        {
            try
            {
                string[] array = { "this", "is", "an", "array" };

                foreach (string n in array)

                {

                    Console.Write(n.ToUpper() + " ");

                }

                Console.WriteLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured.");
            }
        }
        static void SolutionProblem9()
        {
            try
            {
                int[] arr = { 15, 98, 95, 100, 125 };

                int[] arr2 = { 1, 3, 6, 2, 4 };

                int[] tempArr = new int[arr.Length + arr2.Length];

                tempArr = arr.Concat(arr2).ToArray();
                               
                Array.Sort(tempArr);
                               
                foreach (int i in tempArr)

                {

                    Console.Write(i + " ");
                   
                }

                Console.WriteLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occured.");
            }
        }
        static void SolutionProblem10()
        {
            try
            {
                Console.WriteLine("Insert a number: ");

                float value = Convert.ToInt32(Console.ReadLine());

                float temp = 1;

                for (int i = 1; i <= value; i++)

                {
                    Console.WriteLine("temp: " + temp + " and i " + i);
                    temp *= i;

                }

                Console.WriteLine("Factorial of " + value + " is " + temp);
                               
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occured.");
            }
        }

            
    }
    
}
