using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace departments_report
{
    class Municipio
    {
        public int CodigoDane { get; set; }
        public string Nombre  { get; set; }
        public string Tipo { get; set; }

        public Municipio(int codigoDane, string nombre, string tipo) 
        {
            CodigoDane = codigoDane;
            Nombre = nombre;
            Tipo = tipo;
        
        }
    }
}
