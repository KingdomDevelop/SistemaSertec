using GestionVentas.Dato;
using GestionVentas.Dato.Interfaz.IDAO;
using GestionVentas.Negocio.Dto.Usuario;
using GestionVentas.Negocio.Interfaz;
using GestionVentas.Negocio.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Negocio.Implementacion
{
    public class UsuarioSvcImpl : IUsuarioSvc
    {
        private readonly IUsuarioDao _usuarioDao;

        public UsuarioSvcImpl()
        {
            _usuarioDao = DataAccess.UsuarioDao();
        }

        public UsuarioDto obtenerUsuarioLogin(string email, string pass)
        {
            return NegocioMapper.UsuarioToDto(_usuarioDao.ObtenerUsuarioLogin(email, pass));
        }
    }
}
