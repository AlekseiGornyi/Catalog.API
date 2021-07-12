using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.BLL.Responce
{
    public class GenericResponse<T> : General_Responce
    {
        public T gr { get; set; }
    }
}
