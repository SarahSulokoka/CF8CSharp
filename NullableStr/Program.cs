namespace NullableStr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? s1 = null; // Changed to nullable string  
            string? s2 = null;

            s1 = Console.ReadLine();
            s2 = Console.ReadLine();

            // Fixed the tuple syntax and added null checks to avoid dereferencing null values  
            if (s1 != null && s2 != null && s1.Equals("Coding") && s2.Equals("Coding"))
            {
                Console.WriteLine("Bravo");
            }
        }

        public static string GetUpperString(string? s)
        {
            return s?.ToUpper() ?? "Default String"; // Null -conditional  
        }

        public static string GetStringLength(string? s)
        {
            return s?.ToUpper()?? "NULL"; // Coalescing Operator   
        }
    }
}
