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
            bool loggingIn = true;

            while (loggingIn)
            {
                Console.WriteLine("Enter email adress or type Register to register:");
                string emailAdress = Console.ReadLine();
                if (emailAdress == "Register")
                {
                    Register();
                }
                else
                {
                    if (!um.CheckEmailExists(emailAdress))
                    {
                        Console.WriteLine("No accounts associated with this email address found");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Enter Password:");
                        string password = Console.ReadLine();

                        if (!um.CheckPassword(emailAdress, password))
                        {
                            Console.WriteLine("Incorrect Password");
                            Console.WriteLine("");
                        }
                        else
                        {
                            loggingIn = false;
                        }
                    }
                }
            }
        }

        public void Register()
        {
            var um = new UserManagement();
            Console.WriteLine("Register for Library Account");
            Console.WriteLine("======================");
            Console.WriteLine("Enter First Name(s):");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Email Address:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
             
            um.CreateAccount(firstName,lastName,email,password);
            
            Console.WriteLine("");
            Console.WriteLine("Account Created!");
            Console.WriteLine("Returning to Welcome Screen");
            
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