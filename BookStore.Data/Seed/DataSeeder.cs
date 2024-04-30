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

        var authors = new List<Author>
        {
               new Author { Name = "F. Scott Fitzgerald" },
               new Author { Name = "Author 2" },
               new Author { Name = "Author 3" }
        };

        var bookAuthors = new List<BookAuthor>
        {
               new BookAuthor { Book = books[0], Author = authors[0] },
               new BookAuthor { Book = books[0], Author = authors[1] },
               new BookAuthor { Book = books[0], Author = authors[2] }
        };

        var users = new List<User>
        {
               new User { Name = "User 1"},
               new User { Name = "User 2"},
               new User { Name = "User 3"},
               new User { Name = "User 4"}
        };

        var reviews = new List<Review>
        {
               new Review { Book = books[0], Rating = 5, Comment = "Great book!", User = users[0] },
               new Review { Book = books[0], Rating = 4, Comment = "Good book!", User = users[1] },
               new Review { Book = books[0], Rating = 3, Comment = "Ok book!", User = users[2] },
        };

        // Save Users
        if (!context.Users.Any())
        {
            context.Users.AddRange(users);
            context.SaveChanges();
        }

        // Save Authors
        if (!context.Authors.Any())
        {
            context.Authors.AddRange(authors);
            context.SaveChanges();
        }

        // Save Publishers
        if (!context.Publishers.Any())
        {
            context.Publishers.AddRange(publishers);
            context.SaveChanges();
        }

        // Save Subjects
        if (!context.Subjects.Any())
        {
            context.Subjects.AddRange(genres);
            context.SaveChanges();
        }

        // Save Books
        if (!context.Books.Any())
        {
            context.Books.AddRange(books);
            context.SaveChanges();
        }

        // Save BookAuthors
        if (!context.BookAuthors.Any())
        {
            context.BookAuthors.AddRange(bookAuthors);
            context.SaveChanges();
        }

        // Save Reviews
        if (!context.Reviews.Any())
        {
            context.Reviews.AddRange(reviews);
            context.SaveChanges();
        }
    }
}

