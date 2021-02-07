using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

            DrawPieChart();

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

        private void DrawPieChart()
        {
            //reset your chart series and legends
            chart1.Series.Clear();
            chart1.Legends.Clear();

            //Add a new chart-series
            string seriesName = "MySeriesName";
            chart1.Series.Add(seriesName);
            chart1.Series[seriesName].IsValueShownAsLabel = true;

            //Add a new Legend(if needed) and do some formating
            chart1.Legends.Add("MyLegend");
            chart1.Legends[0].LegendStyle = LegendStyle.Table;
            chart1.Legends[0].Alignment = StringAlignment.Center;
            chart1.Legends[0].Title = "MyTitle";
            chart1.Legends[0].BorderColor = Color.Black;

            //set the chart-type to "Pie"
            chart1.Series[seriesName].ChartType = SeriesChartType.Pie;

            Dictionary<string, int> values = country.info();

            //Add some datapoints so the series. in this case you can pass the values to this method
            foreach(KeyValuePair<string,int> val in values)
            {
                chart1.Series[seriesName].Points.AddXY(val.Key, val.Value);
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
