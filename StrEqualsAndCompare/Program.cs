namespace StrEqualsAndCompare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "AUEB";
            string s2 = "AUEB";

            Console.WriteLine($"{s1.Equals(s2)}");
            Console.WriteLine($"{s1 == s2}");
            Console.WriteLine($"{ReferenceEquals(s1, s2)}");

            int result = s1.CompareTo(s2);
            int result2 = string.Compare(s1, s2, true);
        }
    }
}
