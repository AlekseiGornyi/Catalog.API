using System;

namespace Catalog.BLL.Responce.Responce_Interface
{
    public interface IGeneral_Responce
    {
        public bool isSuccess { get; set; }
        public Exception exception { get; set; }
        public string errorMessage { get; set; }
        public string userMessage { get; set; }
    }
}
