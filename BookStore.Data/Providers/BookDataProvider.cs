namespace BooksStore.Data.Providers;

public class BookDataProvider : IBookDataProvider
{
    private readonly AppDbContext _context;

    public BookDataProvider(AppDbContext context)
    {
        _context = context;
    }


    public void AddBook(Book book)
    {
        _context.Books.Add(book);
        _context.SaveChanges();
    }

    public void DeleteBook(int id)
    {
        var book = _context.Books.Find(id);
        _context.Books.Remove(book);
        _context.SaveChanges();
    }

    public double GetAverageRating(int bookId)
    {
        // uses Eager Loading to include the Reviews collection
        // so that we can calculate the average rating.
        var book = _context.Books.Include(b => b.Reviews).FirstOrDefault(b => b.Id == bookId);
        if (book == null)
        {
            return 0;
        }
        return book.Reviews.Average(r => r.Rating);
    }

    public Book GetBook(int id)
    {
        return _context.Books.Find(id);
    }

    public IEnumerable<Book> GetBooks()
    {
        return _context.Books.ToList();
    }

    public IEnumerable<Book> GetBooksByAuthor(int authorId)
    {
        return _context.BookAuthors.Where(ba => ba.AuthorId == authorId).Select(ba => ba.Book).ToList();
    }

    public IEnumerable<Publisher> GetPublishers()
    {
        return _context.Publishers.ToList();
    }

    public IEnumerable<Review> GetReviews(string title)
    {
        return _context.Books
            .Include(b => b.Reviews)
            .Where(b => b.Title == title)
            .SelectMany(b => b.Reviews);
    }

    public IEnumerable<Book> GetUnreviewedBooks()
    {
        return _context.Books
            .Include(b => b.Reviews)
            .Where(b => b.Reviews.Count == 0);
    }

    public void UpdateBook(Book book)
    {
		_context.Books.Update(book);
		_context.SaveChanges();
    }
}

