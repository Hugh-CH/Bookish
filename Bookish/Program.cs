using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Bookish.DataAccess;
using Dapper;

namespace Bookish
{
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new ConsoleWriter();
            
            writer.WelcomeAndLogin();
            
            Console.WriteLine("List of all books in database:");
            Console.WriteLine("");
            writer.PrintAllBooks();
            
            
            //var us = new UserManagement();
            //us.CreateAccount("Bill","Gates","billgates@gmail.com","password");
            
            
        }
    }
}