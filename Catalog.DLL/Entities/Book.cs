namespace Catalog.DAL.Entities
{
    public class Book : Date
    {
        public long Author_Id { get; set; } //FK       
        public long Genre_Id { get; set; } //FK
        public long Status_Id { get; set; } //FK
        public long Id { get; set; }
        public string Name { get; set; }
        public string AboutBook { get; set; }
        //public Date Dates { get; set; }

        //Связи. У каждой книги должен быть автор, описание, жанр и статус(есть, нет, итд.)
        public Author Author { get; set; }        
        public Genre Genre { get; set; }
        public Status Status { get; set; }

    }
}
