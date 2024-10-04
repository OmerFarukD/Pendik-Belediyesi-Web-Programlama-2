using MasterLevelSiCharp.Models;

Console.WriteLine(2+5);


Book book = new Book()
{
    Id = 1,
    Title = "Test",
    Description = "Test",
};

Categgory category = new Categgory()
{
    Id = 1,
    Name = "Dram",
    Books = new List<Book>()
};


category = category + book;

category = category + book;

category = category + book;

category = category + book;

category = category + book;

category.Books.ForEach(x => Console.WriteLine(x));



void AddBookToCategory(Book book)
{
    category.Books.Add(book);
}