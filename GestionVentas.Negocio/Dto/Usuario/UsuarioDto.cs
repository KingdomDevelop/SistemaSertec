using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Negocio.Dto.Usuario
{
   public class UsuarioDto
    {
        public int UsuarioId { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PersonaId { get; set; }
        public bool Estado { get; set; }
    }
}
