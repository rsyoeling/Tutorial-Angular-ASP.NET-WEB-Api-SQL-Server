using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TutorialWebApi.Models
{
    public class Accesoperfil
    {
        public List<AccesoMenu> Menu { get; set; }
        public List<AccesoSubmenu> Submenu { get; set; }
    }

    public class AccesoMenu { 
        public int idMenu { get; set; }
        public string menuNombre { get; set; }
    }

    public class AccesoSubmenu {
        public int idMenu { get; set; }
        public string menuNombre { get; set; }
        public int idSubmenu { get; set; }
        public string submenuNombre { get; set; }
        public string urlPagina { get; set; }
    }
}