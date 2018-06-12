using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas
{
    [Serializable]
    class Pelicula
    {
        String nombre, descripcion;
        DateTime estreno;
        Persona director;
        int presupuesto;
        Estudio estudio;

        public Pelicula(String nombre1, String descripcion1, DateTime estreno1, Persona director1, Estudio estudio1, int presupuesto1)
        {
            nombre = nombre1;
            descripcion = descripcion1;
            estreno = estreno1;
            director = director1;
            presupuesto = presupuesto1;
            estudio = estudio1;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public string GetDescripcion()
        {
            return descripcion;
        }
        public DateTime GetEstreno()
        {
            return estreno;
        }
        public Persona GetDirector()
        {
            return director;
        }
        public int GetPresupuesto()
        {
            return presupuesto;
        }
        public Estudio GetEstudio()
        {
            return estudio;
        }
    }
}
