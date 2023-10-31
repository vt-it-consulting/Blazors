using BooksStore.Models;

namespace BooksStore.Services;

public class BooksService : IBooksService
{
    static List<Book> _allBooks = new List<Book>
    {
        new()
        {
            AuthorName = "John Smith",
            PublishingDate = new DateTime(2021, 01,
                12),
            Title = "Blazor WebAssembly Guide"
        },
        new()
        {
            AuthorName = "John Smith",
            PublishingDate = new DateTime(2022, 03,
                13),
            Title = "Mastering Blazor WebAssembly",
        },
        new()
        {
            AuthorName = "John Smith",
            PublishingDate = new DateTime(2022, 08, 13),
            Title = "Learning Blazor from A to Z"
        }
    };

    public Task<List<Book>> GetAllBooksAsync()
    {
        return Task.FromResult(_allBooks);
    }
}