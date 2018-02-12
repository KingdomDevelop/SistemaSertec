using GestionVentas.Negocio.Dto.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Negocio.Interfaz
{
   public interface IUsuarioSvc
    {
        UsuarioDto obtenerUsuarioLogin(string email, string pass);
    }
}
