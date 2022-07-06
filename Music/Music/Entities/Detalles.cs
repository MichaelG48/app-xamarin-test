using System;
using System.Collections.Generic;
using System.Text;

namespace Music.Entities
{
    public class Detalles
    {
        public string NombreArtista { get; set; }
        public string ImagUrl { get; set; }
        public string Detalle { get; set; }

        public override string ToString()
        {
            return NombreArtista;
        }
    }
    
}
