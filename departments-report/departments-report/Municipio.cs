using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace departments_report
{
    class Municipio
    {
        public string DaneCode { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Municipio(string daneCode, string name, string type) 
        {
            DaneCode = daneCode;
            Name = name;
            Type = type;
        
        }
    }
}
