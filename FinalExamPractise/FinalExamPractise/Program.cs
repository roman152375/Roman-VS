using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Roman!");

            SolutionProblem1(1000, 11256, 500);
            SolutionProblem2(80, 75, 68);
            SolutionProblem3(55495);
            SolutionProblem5("gfsfasesfge");
            Console.ReadKey();
        }
        // all of the methods you write are static

        static void SolutionProblem1(int val1, int val2, int val3)
        {
            try
            {
                int largestVal = 0;

                if (val1 >= val2 && val1 >= val3)
                {
                    largestVal = val1;
                }


                if (val2 >= val1 && val2 >= val3)
                {
                    largestVal = val2;
                }


                if (val3 >= val1 && val3 >= val2)
                {
                    largestVal = val3;
                }
                Console.WriteLine(largestVal.ToString() + " is the Largest.");




            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured!");
            }
        }

        static void SolutionProblem2(float quiz, float mid, float final)
        {
            try
            {
                string Grade = "";
                float sum = quiz + mid + final;
                float average = sum / 3;

                if (average >= 90 && average <= 100)
                {
                    Grade = "A";
                }

                if (average >= 70 && average <= 90)
                {
                    Grade = "B";
                }
                if (average >= 50 && average <= 70)
                {
                    Grade = "C";
                }
                if (average < 50 && average >= 0)
                {
                    Grade = "F";
                }
                Console.WriteLine("Grade " + Grade);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured!");
            }


        }
        static void SolutionProblem3(int input)
        {   

        
            try

            {
                string ConvertInput = "";
                ConvertInput = input.ToString();
                                
                Console.WriteLine("Number of Digits: " + ConvertInput.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured");
            }
        }
        
        static void SolutionProblem5(string input)
        {
            try
            {
                string text = "";
                text = input.ToString();

                Console.WriteLine("Numbers of text: " + text.Length);

            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occured.");
            }
        }
    }
}
