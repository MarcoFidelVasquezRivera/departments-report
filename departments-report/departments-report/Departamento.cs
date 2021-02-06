using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace departments_report
{
    class Departamento
    {

        public string Name {get; set;}
        
        public string Code { get; set; }

        public List<Municipio> Municipios { get; set; }

        public Departamento(String name, string code)
        {
            Name = name;
            Code = code;
            Municipios = new List<Municipio>();
        }

    }
}
