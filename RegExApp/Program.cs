using System.Text.RegularExpressions;

namespace RegExApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "This is CF";
            //bool isMatch = TestCF(s);
            //Console.WriteLine(isMatch);
            string s2 = " 12-02-2025 45-07-1995";

            //TestMatch(s);
            TestGroups(s2);
        }

        public static bool TestCF(string? s)
        {
            string? pattern = @"CF";
            bool isMatch = Regex.IsMatch(s ?? "", pattern);
            return isMatch; // Ensure all code paths return a value
        }

        public static void TestMatch(string? s)
        { string? pattern = @"CF";
            Match match = Regex.Match(s!, pattern);
            if (match.Success)
            {
                Console.WriteLine($"Match found at index {match.Index}");
            }
            else
            {
                Console.WriteLine("No match found");
            }

        }
        public static void TestMatches(string? s)
        {
            string? pattern = @"\b\w{2}\b"; // Matches all two-letter words
            MatchCollection matches = Regex.Matches(s!, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine($"Found match: {match.Value} at index {match.Index}");
            }
        }

        public static string TestGroups(string? s)
        {
            string? pattern = @"(\w+)@(\w+)\.(\w+)"; // Simple email pattern
            MatchCollection matches = Regex.Matches(s!, pattern);

            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    Console.WriteLine($"Full Match: {match.Value}");

                    for (int i = 1; i < match.Groups.Count; i++)
                    {
                        Console.WriteLine($"Group {i}: {match.Groups[i].Value}");
                    }
                }
            }
            return "No match found";
        }

        public static bool TestPassword(string? input)
        {
            return Regex.IsMatch(input!, @"^(?=.*?[a-z])(?=.*?[A-Z])(?=.*?\d)(?=.*?[@$!%*?&])^.{8,}$");
         
        }
    }
}
