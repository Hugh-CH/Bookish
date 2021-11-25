using System.Collections.Generic;
using System.Linq;

namespace Bookish.DataAccess
{
    public class LibrarySystem  
    {
        public List<BookWithAuthors> GetListofBooksWithAuthors()
        {
            
            var db = new ConnectionService();
            var authorBookList = db.GetListOfAuthorBooks();
            var booksWithAuthors = new List<BookWithAuthors>();
            
            booksWithAuthors.Add(new BookWithAuthors(authorBookList[0]));

            for (int i = 1; i < authorBookList.Count; i++)
            {
                if (authorBookList[i].bookid == authorBookList[i - 1].bookid)
                {
                    booksWithAuthors.Last().AddAuthor(authorBookList[i]);
                }
                else
                {
                    booksWithAuthors.Add(new BookWithAuthors(authorBookList[i]));
                }
            }
            return booksWithAuthors;
        }

        public List<string> GetListofBookStrings()
        {
            var db = new ConnectionService();
            var booklist = db.GetListOfBooks().Select(x => x.ToString()).ToList();
            return booklist;
        }

    }
}