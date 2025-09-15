namespace StudentApp
{
    internal class Program
    {
        //default constractor is provided by the compiler
        static void Main(string[] args)
        {
            Student alice = new Student();
            Student bob = new Student();
            var costas = new Student();

            Student student = new Student(); //default constructor
            Student student1 = new Student(1, "Alice", "Johnson"); //parameterized constructor


            //We need setters fot the object initializer syntax to work.
            //We can skip the constructor when using object initializer syntax.
            //We need a default constructor for object initializer syntax to work.
            //We can skip a value when using object initializer syntax.
            //Student student2 = new() {Id = 1, Firstname = "Bob", Lastname = "Smith" }; //object initializer syntax

            Teacher teacher = new() { Id = 1, Firstname = "Sara", Lastname = " Sarah " };
            teacher.Id = 1;
            teacher.Firstname = "Mary";
            teacher.Lastname = "Chatzi ";

            Console.WriteLine($"Id={teacher.Id}, Firstname={teacher.Firstname}, Lastname={teacher.Lastname}");
        }
    }
}
