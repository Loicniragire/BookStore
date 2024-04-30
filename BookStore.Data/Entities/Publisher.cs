namespace Books.Entities;

public class Publisher
{
    public int Id { get; set; }
	public string Name { get; set; }
	public string Website { get; set; }

	// Navigation properties
	public virtual ICollection<Book> Books { get; set; }
}

