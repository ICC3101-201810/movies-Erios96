using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas
{
    [Serializable]
    class PeliculaProductor
    {
        Pelicula pelicula;
        Persona persona;

        public PeliculaProductor(Pelicula p1, Persona p2)
        {
            persona = p2;
            pelicula = p1;
        }
        public Persona GetPersona()
        {
            return persona;
        }
        public Pelicula GetPelicula()
        {
            return pelicula;
        }
    }
}
