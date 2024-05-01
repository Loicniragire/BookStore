namespace BookStore.Data.Entities;

public class Review
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public int UserId { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }


    // Navigation properties
    public virtual Book Book { get; set; }
    public virtual User User { get; set; }
}

