namespace Books.Entities;

public class Book
{
    public int Id { get; set; }
	public string Title { get; set; }
	public int PublisherId { get; set; }
	public int SubjectId { get; set; }
	public DateTimeOffset PublishDate { get; set; }
	public string ISBN { get; set; }
	public string Summary { get; set; }
	public string Notes { get; set; }
	public int PageCount { get; set; }
	public decimal Price { get; set; }

	// Navigation properties
	public virtual ICollection<Review> Reviews { get; set; }
	public virtual Publisher Publisher { get; set; }
	public virtual Subject Subject { get; set; }

}

