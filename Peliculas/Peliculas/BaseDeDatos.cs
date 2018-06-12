using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas
{
    [Serializable]
    class BaseDeDatos
    {
        List<Persona> personas = new List<Persona>();
        List<Estudio> estudios = new List<Estudio>();
        List<Pelicula> peliculas = new List<Pelicula>();
        List<PeliculaActor> peliculaActor = new List<PeliculaActor>();
        List<PeliculaProductor> peliculaProductor = new List<PeliculaProductor>();

        public BaseDeDatos()
        {

        }
        public void agregarPersona(Persona persona)
        {
            personas.Add(persona);
        }
        public void agregarEstudio(Estudio estudio)
        {
            estudios.Add(estudio);
        }
        public void agregarPelicula(Pelicula pelicula)
        {
            peliculas.Add(pelicula);
        }
        public void agregarPeliculaActor(Pelicula pelicula, Persona persona)
        {
            PeliculaActor p = new PeliculaActor(pelicula, persona);
            peliculaActor.Add(p);
        }
        public void agregarPeliculaProductor(Pelicula pelicula, Persona persona)
        {
            PeliculaProductor p = new PeliculaProductor(pelicula, persona);
            peliculaProductor.Add(p);
        }
        public List<Pelicula> GetPeliculas()
        {
            return peliculas;
        }
        public List<Persona> GetPersonas()
        {
            return personas;
        }
        public List<Estudio> GetEstudios()
        {
            return estudios;
        }
        public List<string> ObtenerPeliculasActor(Persona persona)
        {
            List<string> nombres = new List<string>();
            foreach(PeliculaActor a in peliculaActor)
            {
                if(a.GetPersona() == persona)
                {
                    nombres.Add(a.GetPelicula().GetNombre());
                }
            }
            return nombres;
        }
        public List<string> ObtenerPeliculasProducto(Persona persona)
        {
            List<string> nombres = new List<string>();
            foreach (PeliculaProductor a in peliculaProductor)
            {
                if (a.GetPersona() == persona)
                {
                    nombres.Add(a.GetPelicula().GetNombre());
                }
            }
            return nombres;
        }
    }
}
