using LibraryAPP.Models;

namespace LibraryAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var DatabaseRepository = new DatabaseRepository("server=(localdb)\\MSSQLLocalDB; Trusted_Connection=true; database=Library;");
            Console.WriteLine(DatabaseRepository.IsDbConnectionEstablished());
            var Books = DatabaseRepository.GetAllBooks();
            foreach (var book in Books)
            {
                Console.WriteLine(book.Title);
            }
            Console.WriteLine(DatabaseRepository.GetAverageAge());

            Console.WriteLine(DatabaseRepository.GetMaxAvailableCopies().Title);

            var ActiveUsers = DatabaseRepository.GetActiveUsers();
            foreach (var activeuser in ActiveUsers)
            {
                Console.WriteLine(activeuser);
            }

        }
    }
}