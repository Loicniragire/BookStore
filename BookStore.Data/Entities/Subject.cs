namespace BookStore.Data.Entities;

public class Subject
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; } = string.Empty;

    // Navigation properties
    public virtual ICollection<Book> Books { get; set; }

}

