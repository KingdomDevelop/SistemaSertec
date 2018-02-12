using GestionVentas.Dato.Entidades.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Dato.Interfaz.IDAO
{
    public interface IUsuarioDao
    {
        UsuarioEntity ObtenerUsuarioLogin(string correo, string pass);
    }
}
