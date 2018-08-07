using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avika.Forum.WebApiAuthorization.Models
{
    public static class ManagerMessage
    {
        public static Dictionary<string, string> Messages = new Dictionary<string, string>()
        {
            { "SaveSuccess","{0} guardado correctamente." },
            { "SaveError","ocurrio un error al {1} {0}" }   
            //{ "UpdateError","{0} ocurrio un error al guardar" },
            //{ "DeleteError","{0} ocurrio un error al guardar" },
            //{ "SaveError","{0} ocurrio un error al guardar" },
            //{ "SaveError","{0} ocurrio un error al guardar" },
            //{ "SaveError","{0} ocurrio un error al guardar" },
            //{ "SaveError","{0} ocurrio un error al guardar" },
            //{ "SaveError","{0} ocurrio un error al guardar" },
            //{ "SaveError","{0} ocurrio un error al guardar" },
        };
    }
    //    : "",
    //    SaveError= "",
    //};
}