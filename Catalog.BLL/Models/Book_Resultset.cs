namespace Catalog.BLL.Models
{
    public class Book_Resultset
    {
        public long author_Id { get; set; } //FK       
        public long genre_Id { get; set; } //FK
        public long status_Id { get; set; } //FK
        public long id { get; set; }
        public string name { get; set; }
        public string aboutBook { get; set; }
    }
}
