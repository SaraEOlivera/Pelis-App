using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Media
    {
        public int IdPelicula { get; set; }
        public string MediaURL { get; set; }

        public override string ToString()
        {
            return MediaURL;
        }
    }
}
