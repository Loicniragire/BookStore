using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookStore.App.Models;

namespace BookStore.App.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var models = new List<HomeViewModel>()
        {
            new HomeViewModel{StoreName = "Store 1", BookCount = 100, AuthorCount = 10, GenreCount = 5, PublisherCount = 3, ReviewCount = 50},
            new HomeViewModel{StoreName = "Store 2", BookCount = 400, AuthorCount = 90, GenreCount = 9, PublisherCount = 12, ReviewCount = 500}
        };

        return View(models);
    }

    public IActionResult Genres()
    {
        var models = new List<GenresViewModel>()
        {
            new GenresViewModel{Name = "Horror", BookCount = 10},
            new GenresViewModel{Name = "Science Fiction", BookCount = 5},
            new GenresViewModel{Name = "Fantasy", BookCount = 7}
        };
        return View(models);
    }

    public IActionResult Authors()
    {
        return View(new List<AuthorsViewModel>()
                   {
                           new AuthorsViewModel{Name = "Stephen King", BookCount = 10},
                           new AuthorsViewModel{Name = "Loic Niragire", BookCount = 5},
                  });
    }

    public IActionResult Publishers()
    {
        var bookModels = new List<BookViewModel>()
        {
                       new BookViewModel{
                           Title = "The Shining",
                                 Author = "Stephen King",
                                 ISBN = "978-0-385-12167-5",
                                 Category = "Horror",
                                 Language = "English",
                                 Pages = 447,
                                 Price = 10.99m,
                                 Description = "The Shining is a horror novel by American author Stephen King. Published in 1977, it is King's third published novel and first hardback bestseller: the success of the book firmly established King as a preeminent author in the horror genre.",
                                 ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51b0Uf5VHrL._SX331_BO1,204,203,200_.jpg",
                                 Url = "https://www.amazon.com/Shining-Stephen-King/dp/0307743659",
                                 Tags = new string[]{"Horror", "Stephen King", "Penguin"}
                    },

                       new BookViewModel{
                           Title = "It",
                           Author = "Stephen King",
                           ISBN = "978-0-670-81302-8",
                           Category = "Horror",
                           Language = "English",
                           Pages = 1138,
                           Price = 13.99m,
                           Description = "It is a 1986 horror novel by American author Stephen King. It was his 22nd book and 18th novel written under his own name. The story follows the experiences of seven children as they are terrorized by an evil entity that exploits the fears of its victims to disguise itself while hunting its prey.",
                           ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51b0Uf5VHrL._SX331_BO1,204,203,200_.jpg",
                           Url = "https://www.amazon.com/It-Stephen-King/dp/1501142976",
                           Tags = new string[]{"Horror", "Stephen King", "Penguin"}
                    },

                       new BookViewModel{
                           Title = "Carrie",
                           Author = "Stephen King",
                           ISBN = "978-0-385-12167-5",
                           Category = "Horror",
                           Language = "English",
                           Pages = 199,
                           Price = 7.99m,
                           Description = "Carrie is an American epistolary novel and author Stephen King's first published novel, released on April 5, 1974, with an approximate first print-run of 30,000 copies. Set primarily in the then-future year of 1979, it revolves around the eponymous Carrietta N. White, a shy high-school"
            }
        };

        var models = new List<PublishersViewModel>()
        {
               new PublishersViewModel{Name = "Penguin", Books = bookModels}
		};
        return View(models);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
