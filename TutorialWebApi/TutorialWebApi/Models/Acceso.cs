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
    
    public partial class Acceso
    {
        public int idRol { get; set; }
        public int idSubmenu { get; set; }
        public int idMenu { get; set; }
        public string acceso1 { get; set; }
        public Nullable<int> usuarioCreacion { get; set; }
        public Nullable<int> usuarioModificacion { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
    
        public virtual Rol Rol { get; set; }
        public virtual Submenu Submenu { get; set; }
    }
}
