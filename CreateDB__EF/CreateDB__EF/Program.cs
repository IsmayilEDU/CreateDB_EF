using CreateDB__EF.Contexts;

namespace CreateDB__EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using MyLibraryDbContext myLibraryDbContext = new MyLibraryDbContext();
            Console.WriteLine("Hello, World!");
        }
    }
}