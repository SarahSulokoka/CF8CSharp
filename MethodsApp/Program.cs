using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace MethodsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }


        //Add(1,2,3,4,5)
        //Add(new int[]{1,2,3,4,5})
        //JavaScript/Python: Add(...numbers)
        //Java varargs

        public static int add(params int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }


        //Optional Params 
        public static DateTime GetDateTime(int year = 2024, int month = 1, int day = 1)
        {
            return new DateTime(year, month, day);
        }

        public static void PrintMessage(string message, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(message);
            }
        }

        public static void PrintMessage2(string message, ConsoleColor color = ConsoleColor.White, int count = 1)
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(message);
            }
            Console.ResetColor();
        }

        public static bool isEven(int number)
        {
            return number % 2 == 0;
        }

        public static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }

        public static string StrRepeat(string s, int count)
        {
            if (count < 0) return "";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(s);
            }
            return sb.ToString();

        }

        public static bool isPalindromIgnoreCase(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (char.ToLower(s[left]) != char.ToLower(s[right]))
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        public static string RandomPinFourDigits()
        {
            Random rand = new Random();
            int pin = rand.Next(0, 10000); // 0 to 9999
            return pin.ToString("D4"); // Pad with leading zeros if necessary
        }

        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j+1]
                        (arr[j + i], arr[j]) = (arr[j], arr[j + 1]);

                    }
                }
            }
        }
        public static bool isPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            int boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;

        }

        //fibonacci 
        public static int Fibonacci(int n)
        {
            int a = 0, b = 1, c = 0;


            if (n < 0) throw new ArgumentException("Negative arguments are not allowed.");
            if (n == 0) return 0;
            if (n == 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);

            

            //for (int i = 2; i <= n; i++)
            //{
            //    c = a + b;
            //    a = b;
            //    b = c;
            //}
            //return c;
        }
    }
}

