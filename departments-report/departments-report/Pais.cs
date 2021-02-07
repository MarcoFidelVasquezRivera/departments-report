using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace departments_report
{
    class Pais
    {
        public Dictionary<string, Departamento> Departamentos { get; set; }
        public DataTable DataTable { get; set;} 


        public Pais() 
        {
            Departamentos = new Dictionary<string, Departamento>();
            DataTable = new DataTable();
        }

        public void ReadFile(string path)
        {
            var reader = new StreamReader(File.OpenRead(@path));
            string line = reader.ReadLine();
            line = reader.ReadLine();

            while (line != null && !line.Equals("")) 
            {
                Console.WriteLine(line);
                string[] data = line.Split(',');

                
                if (!Departamentos.ContainsKey(data[0]))
                {
                    Departamentos.Add(data[0], new Departamento(data[0], data[2]));
                }

                Municipio toAdd = new Municipio(data[1], data[3], data[4]);
                Departamentos[data[0]].Municipios.Add(toAdd);
                line = reader.ReadLine();
            }

            reader.Close();
        }

        public void generateDataTable()
        {

        }

        public Municipio SearchMunicipio(string code) 
        {
            foreach (KeyValuePair<string, Departamento> Dpt in Departamentos) 
            {

                List<Municipio> Municipios = Dpt.Value.Municipios;

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
