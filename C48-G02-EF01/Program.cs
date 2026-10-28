using static C48_G02_EF01.Author;

namespace C48_G02_EF01
{

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string ISBN { get; set; } = null!;
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int PublishedYear { get; set; }
        public bool InStock { get; set; }


        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }


    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Biography { get; set; }
        public DateTime DateOfBirth { get; set; }

        public List<Book> Books { get; set; } = new();


        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; } = null!;
            public string? Description { get; set; }
            public bool IsActive { get; set; }

            public List<Book> Books { get; set; } = new();
        }




        internal class Program
        {
            static void Main(string[] args)
            {






            }
        }
    }
}
