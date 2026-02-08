namespace Wk4Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#1
            int num = 720142;
            Console.WriteLine(IfNumberContains3(num));

            //#2
            Console.WriteLine(DivisibleBy2Or3(7, 12));

            //#3
            string[] s = ["h", "e", "l", "l", "o"];
            ReverseArrayStringInplace(s);
            Console.Write($"[{string.Join(",", s)}]");
        }

        //1
        public static bool IfNumberContains3(int num) 
        {
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit == 3)
                {
                    return true;
                }

                num = num / 10; // division keeps int as whole number
            }
            return false;
        }

        //2
        public static int DivisibleBy2Or3(int num1, int num2)
        {
            if ((num1 % 2 == 0 || num1 % 3 == 0) && (num2 % 2 == 0 || num2 % 3 == 0))
            {
                return num1 * num2;
            }
            else
            {
                return num1 + num2;
            }
        }

        //3
        public static string[] ReverseArrayStringInplace(string[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                string temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }

            return arr;
        }
    }
}
