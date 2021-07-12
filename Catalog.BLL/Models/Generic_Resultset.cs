using Catalog.BLL.Responce;

namespace Catalog.BLL.Models
{
    public class Generic_Resultset<T> : General_Responce
    {
        public T result_set { get; set; }
    }
}
