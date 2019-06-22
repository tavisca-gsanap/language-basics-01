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

        private static string strcmp(string c, string d)
        {
            int j = 0;
            string ans = "";
            char[] a = c.ToCharArray();
            char[] b = d.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    j++;
                    if (a[i] == '?')
                    {
                        ans = b[i] + "";
                    }
                    else
                    {
                        ans = a[i] + "";
                    }
                }
            }
            if (j != 1)
            {
                ans = "-1";
            }
            return ans;
        }

        public static int FindDigit(string equation)
        {
            // Add your code here.
            string[] a = equation.Split('=');
            string[] b = a[0].Split('*');
            string[] num = { b[0], b[1], a[1] };
            string op = "";
            //for equation like 4?*47=1974
            if (num[0].Contains("?"))
            {
                try
                {
                    int ans = int.Parse(int.Parse(num[2]) / double.Parse(num[1]) + "");
                    op = strcmp(ans + "", num[0]);
                }
                catch (Exception e)
                {
                    op = "-1";
                }

            }
            //for equation like 42*?7=1974
            else if (num[1].Contains("?"))
            {
                try
                {
                    int ans = int.Parse(int.Parse(num[2]) / double.Parse(num[0]) + "");
                    op = strcmp(ans + "", num[1]);
                }
                catch (Exception e)
                {
                    op = "-1";
                }
            }
            //for equation like 42*47=1?74
            else
            {
                int ans = int.Parse(num[0]) * int.Parse(num[1]);
                op = strcmp(ans + "", num[2]);
            }

            Console.WriteLine(op);
            return int.Parse(op);
            //throw new NotImplementedException();

        }
    }

}
