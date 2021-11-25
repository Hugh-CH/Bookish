using Dapper;

namespace Bookish.DataAccess
{
    public class Account
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}