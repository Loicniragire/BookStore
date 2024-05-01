namespace BookStore.Data.Entities;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int PublisherId { get; set; }
    public int SubjectId { get; set; }
    public DateTimeOffset PublishDate { get; set; }
    public string ISBN { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public int PageCount { get; set; }
    public decimal Price { get; set; }

    // Navigation properties
    public virtual ICollection<Review> Reviews { get; set; }
    public virtual Publisher Publisher { get; set; }
    public virtual Subject Subject { get; set; }

}

