using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Trabajador:Persona
    {
        
        int cuil;
        double sueldo, sueldoXhora;
        int horas_trabajadas;
        int puesto;

        public int Cuil
        {
            get { return cuil; }
            set { cuil = value; }
        }
        public double Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        public double SueldoXhora
        {
            get { return sueldoXhora; }
            set { sueldoXhora = value; }
        }

        public int Horas_trabajadas
        {
            get { return horas_trabajadas; }
            set { horas_trabajadas = value; }
        }

        public int Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " $" + Sueldo + " US" ;
        }
    }
}
