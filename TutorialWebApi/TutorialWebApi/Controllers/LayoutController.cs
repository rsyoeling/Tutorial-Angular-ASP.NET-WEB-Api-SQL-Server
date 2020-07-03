using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TutorialWebApi.Models;

namespace TutorialWebApi.Controllers
{
    public class LayoutController : ApiController
    {
        [ResponseType(typeof(Accesoperfil))]
        public IHttpActionResult GetAccesoPerfil(int idRol) {

            var vAccesoperfil = new Accesoperfil();
            List<AccesoMenu> vLstMenu = new List<AccesoMenu>();
            List<AccesoSubmenu> vLstSubmenu = new List<AccesoSubmenu>();

            using (var db = new BDWebApiEntities())
            {
                var cmd = db.Database.Connection.CreateCommand();
                cmd.CommandText = "usProc_Sel_MenuSubMenu";
                cmd.CommandType = CommandType.StoredProcedure;

                DbParameter param = cmd.CreateParameter();
                param.ParameterName = "@idRol";
                param.DbType = DbType.Int32;
                param.Direction = ParameterDirection.Input;
                param.Value = idRol;

                cmd.Parameters.Add(param);

                try
                {
                    db.Database.Connection.Open();
                    // Ejecute el sproc
                    var reader = cmd.ExecuteReader();
                    #region <<Obtener Menu>>
                    // Leer AccesoMenu del primer conjunto de resulados
                    var vMenu = ((IObjectContextAdapter)db)
                        .ObjectContext
                        .Translate<AccesoMenu>(reader, "Menu", MergeOption.AppendOnly);

                    foreach (var item in vMenu)
                    {
                        AccesoMenu oMenu = new AccesoMenu();
                        oMenu.idMenu = item.idMenu;
                        oMenu.menuNombre = item.menuNombre;
                        vLstMenu.Add(oMenu);
                    }
                    #endregion

                    #region <<Obtener SubMenu>>
                    // Leer AccesoSubMenu del segundo conjunto de resultodo
                    reader.NextResult();
                    var vSubMenu = ((IObjectContextAdapter)db)
                        .ObjectContext
                        .Translate<AccesoSubmenu>(reader, "Submenu", MergeOption.AppendOnly);

                    foreach (var item in vSubMenu)
                    {
                        AccesoSubmenu oSubMenu = new AccesoSubmenu();
                        oSubMenu.idMenu = item.idMenu;
                        oSubMenu.menuNombre = item.menuNombre;
                        oSubMenu.idSubmenu = item.idSubmenu;
                        oSubMenu.submenuNombre = item.submenuNombre;
                        oSubMenu.urlPagina = item.urlPagina;
                        vLstSubmenu.Add(oSubMenu);
                    }
                    #endregion

                    vAccesoperfil.Menu = vLstMenu;
                    vAccesoperfil.Submenu = vLstSubmenu;

                    return Ok(vAccesoperfil);
                }
                finally
                {
                    db.Database.Connection.Close();
                }
            }
        }
    }
}
