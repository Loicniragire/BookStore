namespace Books.Entities;

public class User
{
    public int Id { get; set; }
	public string Name { get; set; }

	// Navigation properties
	public virtual ICollection<Review> Reviews { get; set; }
	
}


