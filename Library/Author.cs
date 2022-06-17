using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Author
    {
        public string  Name { get; set; }
        public string  SurName { get; set; }
        public List<Books> authorbooks;
        public int AuthorId { get; }
        private static int _authorId=1;

    public Author()
        {
            authorbooks = new();
            AuthorId = ++_authorId;

        }
    }

}
