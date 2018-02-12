using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVentas.Dato.Entidades.Usuario
{
    public class UsuarioEntity
    {
        public int UsuarioId { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PersonaId { get; set; }
        public bool Estado { get; set; }
    }
}
