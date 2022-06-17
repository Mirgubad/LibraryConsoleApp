using System.Collections.Generic;

namespace Library
{
    class Books
    {
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public string Format { get; set; }
        public int BId { get; }
        private static int _bId = 1;
        public List<Author> authors;
        public Books()
        {
            BId = _bId;
            ++_bId;
            authors = new();
        }
    }
}
