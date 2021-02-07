
namespace departments_report
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.toSearch = new System.Windows.Forms.TextBox();
            this.nombreMunicipio = new System.Windows.Forms.Label();
            this.codigoMunicipio = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.Label();
            this.nombreDepartamento = new System.Windows.Forms.Label();
            this.codigoDepartamento = new System.Windows.Forms.Label();
            this.codeM = new System.Windows.Forms.Label();
            this.tipoM = new System.Windows.Forms.Label();
            this.nombreD = new System.Windows.Forms.Label();
            this.codigoD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "load file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 367);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del municipio;";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(582, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toSearch
            // 
            this.toSearch.Location = new System.Drawing.Point(664, 93);
            this.toSearch.Name = "toSearch";
            this.toSearch.Size = new System.Drawing.Size(100, 20);
            this.toSearch.TabIndex = 4;
            // 
            // nombreMunicipio
            // 
            this.nombreMunicipio.AutoSize = true;
            this.nombreMunicipio.Location = new System.Drawing.Point(697, 135);
            this.nombreMunicipio.Name = "nombreMunicipio";
            this.nombreMunicipio.Size = new System.Drawing.Size(0, 13);
            this.nombreMunicipio.TabIndex = 5;
            // 
            // codigoMunicipio
            // 
            this.codigoMunicipio.AutoSize = true;
            this.codigoMunicipio.Location = new System.Drawing.Point(582, 152);
            this.codigoMunicipio.Name = "codigoMunicipio";
            this.codigoMunicipio.Size = new System.Drawing.Size(108, 13);
            this.codigoMunicipio.TabIndex = 6;
            this.codigoMunicipio.Text = "Codigo del Municipio:\r\n";
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.Location = new System.Drawing.Point(659, 165);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(31, 13);
            this.tipo.TabIndex = 7;
            this.tipo.Text = "Tipo:";
            // 
            // nombreDepartamento
            // 
            this.nombreDepartamento.AutoSize = true;
            this.nombreDepartamento.Location = new System.Drawing.Point(558, 178);
            this.nombreDepartamento.Name = "nombreDepartamento";
            this.nombreDepartamento.Size = new System.Drawing.Size(132, 13);
            this.nombreDepartamento.TabIndex = 8;
            this.nombreDepartamento.Text = "Nombre del departamento:";
            this.nombreDepartamento.Click += new System.EventHandler(this.label4_Click);
            // 
            // codigoDepartamento
            // 
            this.codigoDepartamento.AutoSize = true;
            this.codigoDepartamento.Location = new System.Drawing.Point(562, 191);
            this.codigoDepartamento.Name = "codigoDepartamento";
            this.codigoDepartamento.Size = new System.Drawing.Size(128, 13);
            this.codigoDepartamento.TabIndex = 9;
            this.codigoDepartamento.Text = "Codigo del departamento:";
            // 
            // codeM
            // 
            this.codeM.AutoSize = true;
            this.codeM.Location = new System.Drawing.Point(697, 152);
            this.codeM.Name = "codeM";
            this.codeM.Size = new System.Drawing.Size(0, 13);
            this.codeM.TabIndex = 10;
            // 
            // tipoM
            // 
            this.tipoM.AutoSize = true;
            this.tipoM.Location = new System.Drawing.Point(697, 165);
            this.tipoM.Name = "tipoM";
            this.tipoM.Size = new System.Drawing.Size(0, 13);
            this.tipoM.TabIndex = 11;
            // 
            // nombreD
            // 
            this.nombreD.AutoSize = true;
            this.nombreD.Location = new System.Drawing.Point(697, 178);
            this.nombreD.Name = "nombreD";
            this.nombreD.Size = new System.Drawing.Size(0, 13);
            this.nombreD.TabIndex = 12;
            // 
            // codigoD
            // 
            this.codigoD.AutoSize = true;
            this.codigoD.Location = new System.Drawing.Point(697, 191);
            this.codigoD.Name = "codigoD";
            this.codigoD.Size = new System.Drawing.Size(0, 13);
            this.codigoD.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.codigoD);
            this.Controls.Add(this.nombreD);
            this.Controls.Add(this.tipoM);
            this.Controls.Add(this.codeM);
            this.Controls.Add(this.codigoDepartamento);
            this.Controls.Add(this.nombreDepartamento);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.codigoMunicipio);
            this.Controls.Add(this.nombreMunicipio);
            this.Controls.Add(this.toSearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox toSearch;
        private System.Windows.Forms.Label nombreMunicipio;
        private System.Windows.Forms.Label codigoMunicipio;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.Label nombreDepartamento;
        private System.Windows.Forms.Label codigoDepartamento;
        private System.Windows.Forms.Label codeM;
        private System.Windows.Forms.Label tipoM;
        private System.Windows.Forms.Label nombreD;
        private System.Windows.Forms.Label codigoD;
    }
}

