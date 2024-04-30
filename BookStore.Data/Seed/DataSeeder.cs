namespace Books.Data;

public static class DataSeeder
{
    public static void SeedData(AppDbContext context)
    {
        var genres = new List<Subject>
        {
               new Subject { Name = "Fiction" },
               new Subject { Name = "Non-Fiction" },
               new Subject { Name = "Science Fiction" },
               new Subject { Name = "Fantasy" },
               new Subject { Name = "Mystery" },
               new Subject { Name = "Horror" },
               new Subject { Name = "Romance" },
               new Subject { Name = "Biography" },
               new Subject { Name = "Self-Help" },
               new Subject { Name = "Cooking" },
               new Subject { Name = "History" },
               new Subject { Name = "Travel" },
               new Subject { Name = "Health" },
               new Subject { Name = "Children" },
               new Subject { Name = "Young Adult" }
        };

        var publishers = new List<Publisher>
        {
               new Publisher { Name = "Penguin Random House" },
               new Publisher { Name = "HarperCollins" },
               new Publisher { Name = "Simon & Schuster" },
               new Publisher { Name = "Macmillan" },
               new Publisher { Name = "Hachette Livre" }
        };

        if (!context.Publishers.Any())
        {
            context.Publishers.AddRange(publishers);
            context.SaveChanges();
        }
        if (!context.Books.Any())
        {
            var books = new List<Book>
            {
                   new Book { Title = "The Great Gatsby",
                                Publisher = publishers[0],
                                Subject = genres[0],
                                ISBN = "9780743273565",
                                PublishDate = new DateTime(2004, 9, 8),
                                Price = 7.99m,
                                PageCount = 180,
                                Notes = "The story of the mysteriously wealthy Jay Gatsby and his love for the beautiful Daisy Buchanan, of lavish parties on Long Island at a time when The New York Times noted “gin was the national drink",
                             Summary = "The story of the mysteriously wealthy Jay Gatsby and his love for the beautiful Daisy Buchanan, of lavish parties on Long Island at a time when The New York Times noted “gin was the national drink"

                   },



        };

        }
    }
}

