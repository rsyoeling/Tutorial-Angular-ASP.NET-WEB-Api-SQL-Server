//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TutorialWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public int idUsuario { get; set; }
        public int idRol { get; set; }
        public string nombres { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string usuario1 { get; set; }
        public string clave { get; set; }
        public string correoElectronico { get; set; }
        public string telefonoOficina { get; set; }
        public Nullable<bool> AccesoPrimeraVez { get; set; }
        public string ultimasContrasenas { get; set; }
        public Nullable<bool> contrasenaEncriptada { get; set; }
        public Nullable<bool> status { get; set; }
        public Nullable<int> usuarioCreacion { get; set; }
        public Nullable<int> usuarioModificacion { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
    
        public virtual Rol Rol { get; set; }
    }
}