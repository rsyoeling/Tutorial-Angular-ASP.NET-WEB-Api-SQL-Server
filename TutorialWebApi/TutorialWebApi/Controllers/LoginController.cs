using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TutorialWebApi.Models;

namespace TutorialWebApi.Controllers
{
    public class LoginController : ApiController
    {
        public IQueryable<AUsuario> GetAuthenticate(string usuario, string contrasena) {
            using (var context = new BDWebApiEntities())
            {
                var clientUsuario = new SqlParameter("@usuario", usuario);
                var clientContrasena = new SqlParameter("@contrasena", contrasena);

                var result = context.Database
                    .SqlQuery<AUsuario>("usp_ValidaAcceso @usuario, @contrasena", clientUsuario, clientContrasena)
                    .ToList();
                return result.AsQueryable();
            }
        }
    }
}
