using System;

namespace Bookish.DataAccess
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }

        public string ToString()
        {
            return $"{Title}";
        }

    }
}