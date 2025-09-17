namespace LinqApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Query syntax 
            //var evenNumbersQuery = from num in numbers
            //                       where num % 2 == 0
            //                       select num;
        }

        public static IEnumerable<int> GetAllNumbers(int[] numbers) {
            return from num in numbers
                   select num;
          
        }
}
}
