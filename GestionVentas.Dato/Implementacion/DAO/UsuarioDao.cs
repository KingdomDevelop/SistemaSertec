using GestionVentas.Dato.Contexto;
using GestionVentas.Dato.Entidades.Usuario;
using GestionVentas.Dato.Interfaz.IDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Dato.Implementacion.DAO
{
    public class UsuarioDao : IUsuarioDao
    {
        public UsuarioEntity ObtenerUsuarioLogin(string correo, string pass)
        {
            var usuario = new UsuarioEntity();

            using (var context = new ContextoBdSantiago())
            {
                var datos = context.Usuario;

                if (datos.Any())
                {
                    var usuarioValido = datos.Where(c => c.Email == correo & c.Password == pass).FirstOrDefault();

                    if (usuarioValido != null)
                    {
                        usuario.Email = usuarioValido.Email;
                        usuario.Estado = (bool)usuarioValido.Estado;
                        usuario.Login = usuarioValido.Login;
                        usuario.Password = usuarioValido.Password;
                        usuario.UsuarioId = (int)usuarioValido.Usuario_id;
                    }
                }
            }

            return usuario;
        }
    }
}
