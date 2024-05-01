

var allBooks = new List<Libratest.Books>()
{
    new Libratest.Books()
    {
        Title = "Book 1"
    },
    new Libratest.Books()
    {
        Title = "book2 "
    }
};


foreach (var book in allBooks)
{
    Console.WriteLine(book.Title);
}

Console.ReadLine();