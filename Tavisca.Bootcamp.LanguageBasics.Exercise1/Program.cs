using System;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("42*47=1?74", 9);
            Test("4?*47=1974", 2);
            Test("42*?7=1974", 4);
            Test("42*?47=1974", -1);
            Test("2*12?=247", -1);
            Console.ReadKey(true);
        }

        private static void Test(string args, int expected)
        {
            var result = FindDigit(args).Equals(expected) ? "PASS" : "FAIL";
            Console.WriteLine($"{args} : {result}");
        }

        public static int FindDigit(string equation)
        {
            // Add your code here.
            string[] numbers = equation.Split('*','=');
            string outputDigit = "";
            int actualAnswerOfExpression;
            StringCompare stringCompare = new StringCompare();
            //for equation like 4?*47=1974
            if (numbers[0].Contains("?"))
            {
                try
                {
                    actualAnswerOfExpression = Int32.Parse(Int32.Parse(numbers[2]) / Double.Parse(numbers[1]) + "");
                    outputDigit = stringCompare.StringComparer(actualAnswerOfExpression + "", numbers[0]);
                }
                catch (Exception e)
                {
                    outputDigit = "-1";
                }

            }
            //for equation like 42*?7=1974
            else if (numbers[1].Contains("?"))
            {
                try
                {
                    actualAnswerOfExpression = Int32.Parse(Int32.Parse(numbers[2]) / Double.Parse(numbers[0]) + "");
                    outputDigit = stringCompare.StringComparer(actualAnswerOfExpression + "", numbers[1]);
                }
                catch (Exception e)
                {
                    outputDigit = "-1";
                }
            }
            //for equation like 42*47=1?74
            else
            {
                actualAnswerOfExpression = Int32.Parse(numbers[0]) * Int32.Parse(numbers[1]);
                outputDigit = stringCompare.StringComparer(actualAnswerOfExpression + "", numbers[2]);
            }

            Console.WriteLine(outputDigit);
            return Int32.Parse(outputDigit);
            //throw new NotImplementedException();

        }
    }

}
