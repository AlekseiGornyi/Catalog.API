using System;

namespace Catalog.DAL.EntityDTO
{
    public class BookDTO
    {
        public long Author_Id { get; set; } //FK       
        public long Genre_Id { get; set; } //FK
        public long Status_Id { get; set; } //FK
        public long Id { get; set; }
        public string Name { get; set; }
        public string AboutBook { get; set; }
        //DateTime ModifiedDate { get; set; }
    }
}
