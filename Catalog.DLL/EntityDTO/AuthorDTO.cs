using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.DAL.EntityDTO
{
    public class AuthorDTO
    {
        public long Id { get; set; }
        public string AuthorName { get; set; }
        public string AboutAuthor { get; set; }
        //public Date ModifiedDate { get; set; }
    }
}
