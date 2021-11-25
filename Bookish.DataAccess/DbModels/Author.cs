namespace Bookish.DataAccess
{
    public class Author
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Author(AuthorBook authorBook)
        {
            id = authorBook.authorid;
            FirstName = authorBook.Firstname;
            LastName = authorBook.Lastname;
        }
    }
}