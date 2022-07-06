using System;
using System.Collections.Generic;
using System.Text;

namespace Music.Entities
{
    public class Cantante
    {
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string ImagenUrl { get; set; }
        public string Detalle { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
