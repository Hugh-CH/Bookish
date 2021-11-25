using System.Collections.Generic;

namespace Bookish.DataAccess
{
    public class BookWithAuthors
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public List<Author> Authors { get; set; }

        public BookWithAuthors(AuthorBook authorBook)
        {
            Id = authorBook.bookid;
            Title = authorBook.title;
            ISBN = authorBook.ISBN;
            Authors = new List<Author>();
            var author = new Author(authorBook);
            Authors.Add(author);
        }

        public void AddAuthor(AuthorBook authorBook)
        {
            var author = new Author(authorBook);
            Authors.Add(author);
        }
    }
}