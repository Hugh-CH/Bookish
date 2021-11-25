using System;
using Bookish.DataAccess;

namespace Bookish
{
    public class ConsoleWriter
    {
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