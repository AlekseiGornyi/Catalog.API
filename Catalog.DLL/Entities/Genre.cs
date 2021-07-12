using System.Collections.Generic;

namespace Catalog.DAL.Entities
{
    public class Genre : Date
    {
        
        public long Id { get; set; }
        public string Genres { get; set; }
        //public Date Dates { get; set; }

        //Связь, у одного жанра может быть множество книг
        public ICollection<Book> Books { get; set; }
        public ICollection<Author> Author { get; set; }
    }
}
