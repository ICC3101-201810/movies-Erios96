using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas
{
    [Serializable]
    class Estudio
    {
        String nombre, direccion;
        DateTime fechaApertura;

        public Estudio(String nombre1, String direccion1, DateTime fecha)
        {
            nombre = nombre1;
            direccion = direccion1;
            fechaApertura = fecha;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public string GetDireccion()
        {
            return direccion;
        }
        public DateTime GetApertura()
        {
            return fechaApertura;
        }
    }
}
