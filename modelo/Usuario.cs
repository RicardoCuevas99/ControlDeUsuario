using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenTecnico.modelo
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string usuario { get; set; }
        public int TipoUsuario { get; set; }
        public string Area { get; set; }
        public int Activo { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
    }
}
