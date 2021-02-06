using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace departments_report
{
    class Pais
    {
        public List<Departamento> Departamentos { get; set; }


        public Pais() 
        { 

        }

        public void ReadFile(string path)
        {
            var reader = new StreamReader(File.OpenRead(@path));
            string line = reader.ReadLine();

            while(line != null) 
            {
                string[] data = line.Split(',');
                //CÃ³digo Departamento,CÃ³digo Municipio,Nombre Departamento,Nombre Municipio,Tipo: Municipio / Isla / Ãrea no municipalizada
                foreach(Departamento dpt in Departamentos) 
                {
                    if (!(dpt.Code.Equals(data[0]))) 
                    {
                        Departamentos.Add(new Departamento(data[0], data[2]));
                    }
                
                
                }

                Municipio toAdd = new Municipio(data[1], data[3], data[4]);
                
                foreach(Departamento dpt in Departamentos) 
                {
                    if (dpt.Code.Equals(data[0])) 
                    {

                        dpt.Municipios.Add(toAdd);        
                    }
                }

            }



        }


        public Municipio SearchMunicipio(string code) 
        {
            foreach (Departamento Dpt in Departamentos) 
            {

                List<Municipio> Municipios = Dpt.Municipios;
                foreach(Municipio mcp in Municipios) 
                {
                    if (mcp.DaneCode.Equals(code)) 
                    {
                        return mcp;
                    
                    }            
                }

            }
            return null;
        }
    }
}
