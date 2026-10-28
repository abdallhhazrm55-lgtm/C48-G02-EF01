using Microsoft.EntityFrameworkCore;
using static C48_G02_EF01.Author;

namespace C48_G02_EF01
{
    internal class BookstoreContext : DbContext

    {


        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=ReadMoreBooksDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }


    }
}

