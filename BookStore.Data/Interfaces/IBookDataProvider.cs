namespace BookStore.Data.Interfaces;

public interface IBookDataProvider
{
    /// <summary>
    /// Retrieves all books from the data source.
    /// </summary>
    IEnumerable<Book> GetBooks();
    Book GetBook(int id);

    // Get all publishers with their books
    IEnumerable<Publisher> GetPublishers();

    // Find books for specific author
    IEnumerable<Book> GetBooksByAuthor(int authorId);

    // Get all reviews for a book with a specific title
    IEnumerable<Review> GetReviews(string title);

    // Calculate average rating for a book with a specific id
    double GetAverageRating(int bookId);

    // Find books that have not been reviewed
    IEnumerable<Book> GetUnreviewedBooks();

    void AddBook(Book book);
    void UpdateBook(Book book);
    void DeleteBook(int id);
}

