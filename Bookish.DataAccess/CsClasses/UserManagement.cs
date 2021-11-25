using System.Data.Common;
using System.Threading.Channels;

namespace Bookish.DataAccess
{
    public class UserManagement
    {
        public void CreateAccount(string firstName,string lastName, string email, string password)
        {
            var db = new ConnectionService();
            db.CreateAccount(firstName,lastName,email,password);
            
        }
    }
}