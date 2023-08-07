using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Persona
    {
        string nombre;
        string apellido;
        int cantidad_hijos;
        bool casado;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int CantidadHijos
        {
            get { return cantidad_hijos; }
            set { cantidad_hijos = value; }
        }

        public bool Casado
        {
            get { return casado; }
            set { casado = value; }
        }

        public override string ToString()
        {
            return nombre + " " + apellido ;
        }
    }
}
