using System;
using System.Collections.Generic;
using System.Text;

namespace Music.Entities
{
    public class Inicio
    {
        public string Nombre { get; set; }
        public string ImagenUrl { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
