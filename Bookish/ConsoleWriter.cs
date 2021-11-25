using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using Bookish.DataAccess;

namespace Bookish
{
    public class ConsoleWriter
    {
        public void WelcomeAndLogin()
        {

            var um = new UserManagement();
            Console.WriteLine("welcome to the Library");
            Console.WriteLine("Enter email adress or type Register to register:");
            string emailAdress = Console.ReadLine();

            if (emailAdress == "Register")
            {
                System.Environment.Exit(0);
            }else
            {
                if (!um.CheckEmailExists(emailAdress))
                {
                    Console.WriteLine("Account Not Found");
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Enter Password:");
                    string password = Console.ReadLine();
                    
                    if(!um.CheckPassword(emailAdress, password))
                    {
                        System.Environment.Exit(0);
                    }
                }
            }
        }
        
        
        
        
        
        
        
        
        
        
        
        public void PrintAllBooks()
        {
            var listGenerator = new LibrarySystem();
            var listOfStrings = listGenerator.GetListofBookStrings();
            listGenerator.GetListofBooksWithAuthors();
            foreach (var title in listOfStrings) 
            {
                Console.WriteLine(title);
            }
        }
        
        
        
        
        
    }
}