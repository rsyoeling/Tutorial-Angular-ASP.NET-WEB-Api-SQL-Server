using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TutorialWebApi.Models
{
    public class AUsuario
    {
        public int idUsuario { get; set; }
        public int idRol { get; set; }
        public string nombres { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string usuario { get; set; }
        public string correoElectronico { get; set; }
        public string telefonoOficina { get; set; }
    }
}