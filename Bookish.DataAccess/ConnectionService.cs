using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using Dapper;

namespace Bookish.DataAccess
{
    public class ConnectionService
    {
        IDbConnection db = new SqlConnection("Server=localhost;Trusted_Connection=True");

        public List<Book> GetListOfBooks()
        {
            string SqlString = "SELECT * FROM [Books]";
            return (List<Book>) db.Query<Book>(SqlString);
        }
        
        public List<Author> GetListOfAuthors()
        {
            string SqlString = "SELECT * FROM [Authors]";
            return (List<Author>) db.Query<Author>(SqlString);
        }
        
        public List<AuthorBook> GetListOfAuthorBooks()
        {
            string SqlString = "SELECT b.id bookid,b.Title,b.ISBN,a.id authorid,a.FirstName,a.Lastname  FROM Authors a INNER JOIN AuthorBooks AB on a.id = AB.Author INNER JOIN Books b on ab.Book = b.id ORDER BY bookid;";
            return (List<AuthorBook>) db.Query<AuthorBook>(SqlString);
        }
        
        public List<AuthorBook> GetListOfAuthorBookIDs()
        {
            string SqlString = "SELECT * FROM [Authors]";
            return (List<AuthorBook>) db.Query<AuthorBook>(SqlString);
        }

        public void CreateAccount(string firstName, string lastName, string email, string password)
        {
            string SqlString = $"INSERT INTO Users (FirstName,LastName,email,password) VALUES ('{firstName}', '{lastName}','{email}','{password}')";
            db.Execute(SqlString);
        }

        public bool CheckEmailExists(string email)
        {
            string SqlString = $"SElECT email FROM Users WHERE email = '{email}'";
            
            
            var response = db.Query<string>(SqlString);

            return response.ToList().Count != 0;
        }
        
        public bool CheckPassword(string email,string password)
        {
            string SqlString = $"SElECT email FROM Users WHERE email = '{email}' and password = '{password}'";
            
            var response = db.Query<string>(SqlString);

            return response.ToList().Count != 0;
        }


    }
}