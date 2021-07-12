namespace Catalog.API.Models.Book
{
    public class BookUpdate_Pass_Object : Book_Pass_Object
    {
        public long id { get; set; }
        public long status_id { get; set; }
        public long genre_id { get; set; }
    }
}
