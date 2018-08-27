using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avika.Forum.WebApiAuthorization.Models
{
    public class Conexion
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string ConexionString { get; set; }
    }
}