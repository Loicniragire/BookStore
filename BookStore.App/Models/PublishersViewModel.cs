namespace BookStore.App.Models;

public class PublishersViewModel
{
    public string Name { get; set; }
	public IEnumerable<BookViewModel> Books { get; set; }
}

