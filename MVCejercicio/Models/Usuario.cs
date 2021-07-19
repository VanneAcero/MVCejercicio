using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCejercicio.Models
{
    public class Usuario
    {
        public string Cedula {get; set;}
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Genero { get; set; }
    }
}
