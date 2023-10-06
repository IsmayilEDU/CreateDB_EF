using CreateDB__EF.Entities.DerivedEntities;
using Microsoft.EntityFrameworkCore;

namespace CreateDB__EF.Contexts
{
    public class MyLibraryDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-0V84BDI\\SQLEXPRESS;Database=MyLibrary;Integrated Security=True;Connect Timeout=30;Encrypt=False");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Operation> Operations { get; set; }
    }
}

