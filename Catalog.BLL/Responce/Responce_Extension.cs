using Catalog.BLL.Responce.Responce_Interface;
using System;

// TODO нужно править.

namespace Catalog.BLL.Responce
{
    public static class Responce_Extension
    {
        public static void Error(this IGeneral_Responce responce, string method, Exception exception)
        {
            responce.isSuccess = false;

            if(exception != null)
            {
                responce.errorMessage = exception.Message;
            }            
        }
    }
}
