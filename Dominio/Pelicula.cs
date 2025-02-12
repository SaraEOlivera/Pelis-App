using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pelicula
    {
        [DisplayName("Película")]
        public string Titulo { get; set; }
        public string Bio { get; set; }

        [DisplayName("Estreno")]
        public DateTime? FechaEstreno { get; set; }
        public int Duracion { get; set; }
        public Media Media { get; set; }
        [DisplayName("Categoría")]
        public Categorias Categorias { get; set; }
        [DisplayName("Clasificación")]
        public Clasificaciones Clasificaciones { get; set; }
        [DisplayName("Plataforma")]
        public Plataformas Plataformas { get; set; }
    }
}
