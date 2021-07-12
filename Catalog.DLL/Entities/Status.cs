using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.DAL.Entities
{
    public class Status : Date
    {
        public long Id { get; set; }       
        public string Name { get; set; }
        //public Date Dates { get; set; }

        //Связь у одного статус может быть множество книг.
        public ICollection<Book> Books { get; set; }
    }
}
