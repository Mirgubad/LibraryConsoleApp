using System.Collections.Generic;

namespace Library
{
    class Library
    {
        public string Name { get; set; }

        public List<Employees> employees;
        public List<Books> books;
        public List<Author> authors;

        public Library()
        {
            employees = new();
            books = new();
            authors = new();
        }
    }
}
