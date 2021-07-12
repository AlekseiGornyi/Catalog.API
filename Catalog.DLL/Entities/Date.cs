using System;

namespace Catalog.DAL.Entities
{
    public class Date
    {
        // В каждом классе Ентити будет свой экземпляр класса Дата, он будет описывать наличие полей с одниковым именем
        // в каждом классе.
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
