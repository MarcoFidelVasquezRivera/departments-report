using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace departments_report
{
    partial class Form1 : Form
    {
        public Pais country;

        public Form1()
        {
            InitializeComponent();
            country = new Pais();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "csv files (*.csv)|*.csv";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;

                country.ReadFile(selectedFileName);

                dataGridView1.DataSource = country.DataTable;
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (toSearch.Text != null)
            {
                string code = toSearch.Text;
                string found = country.SearchMunicipio(code);

                if (found != null)
                {
                    string[] replace = found.Split(',');
                    nombreMunicipio.Text = replace[0];
                    codeM.Text = replace[1];
                    tipoM.Text = replace[2];
                    nombreD.Text = replace[3];
                    codigoD.Text = replace[4];
                }
                else 
                {
                    nombreMunicipio.Text = "El codigo es incorrecto";
                
                
                
                }
            }
            else 
            {

                Console.WriteLine( "¯|_(ツ)_|¯");
            
            }
            





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
