using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas
{
    [Serializable]
    class Persona
    {
        String nombre, apellido, bibliografia, tipo;
        DateTime fechaNacimiento;
        public Persona(String nombre1, String apellido1, String bibliografia1, DateTime date, String tipo1)
        {
            nombre = nombre1;
            apellido = apellido1;
            bibliografia = bibliografia1;
            fechaNacimiento = date;
            tipo = tipo1;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public string GetApellido()
        {
            return apellido;
        }
        public string GetBibliografia()
        {
            return bibliografia;
        }
        public string GetTipo()
        {
            return tipo;
        }
        public DateTime GetFechaNacimiento()
        {
            return fechaNacimiento;
        }

    }
}
