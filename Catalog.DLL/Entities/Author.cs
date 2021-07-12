using System.Collections.Generic;

namespace Catalog.DAL.Entities
{
    public class Author : Date
    {
        public long Id { get; set; }
        public string AuthorName { get; set; }
        public string AboutAuthor { get; set; }
        //public Date Dates { get; set; }

        //Связь у одного автора может быть множество книг.
        public ICollection<Book> Books { get; set; }
        public ICollection<Genre> Genres { get; set; }
    }
}
