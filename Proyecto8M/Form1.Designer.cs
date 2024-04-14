namespace Proyecto8M
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbPefil = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.lblLogro = new System.Windows.Forms.Label();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.cmbNacionalidad = new System.Windows.Forms.ComboBox();
            this.btnPromedioEdades = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPefil
            // 
            this.cmbPefil.FormattingEnabled = true;
            this.cmbPefil.Items.AddRange(new object[] {
            "Ada Lovelace",
            "Barbara Thoens",
            "Betty Snyder Holberton",
            "Carol Shaw",
            "Erna Schneider Hoover",
            "Evelyn Berezin",
            "Frances E. Allen",
            "Grace Murray Hopper",
            "Hedy Lemarr",
            "Jean Bartik",
            "Jean E. Sammet",
            "Joan Clarke",
            "Joanna Rutkowska",
            "Jude Milhon",
            "Karen Spärck Jones",
            "Kathleen McNulty Mauchly Anton",
            "Lynn Conway",
            "Margaret Hamilton",
            "Marlyn Wescoff Meltze",
            "Radia Perlman",
            "Rózsa Péter",
            "Ruth Lichterman Teitelbaum",
            "Gertrude Blanch"});
            this.cmbPefil.Location = new System.Drawing.Point(10, 20);
            this.cmbPefil.Name = "cmbPefil";
            this.cmbPefil.Size = new System.Drawing.Size(170, 21);
            this.cmbPefil.TabIndex = 0;
            this.cmbPefil.SelectedIndexChanged += new System.EventHandler(this.cmbPefil_SelectedIndexChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(10, 50);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(10, 80);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 13);
            this.lblFecha.TabIndex = 2;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(10, 110);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(0, 13);
            this.lblNacionalidad.TabIndex = 3;
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.AutoSize = true;
            this.lblOcupacion.Location = new System.Drawing.Point(10, 140);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(0, 13);
            this.lblOcupacion.TabIndex = 4;
            // 
            // lblLogro
            // 
            this.lblLogro.Location = new System.Drawing.Point(10, 170);
            this.lblLogro.Name = "lblLogro";
            this.lblLogro.Size = new System.Drawing.Size(234, 108);
            this.lblLogro.TabIndex = 5;
            // 
            // pcbFoto
            // 
            this.pcbFoto.Location = new System.Drawing.Point(250, 20);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(170, 170);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 6;
            this.pcbFoto.TabStop = false;
            // 
            // cmbNacionalidad
            // 
            this.cmbNacionalidad.FormattingEnabled = true;
            this.cmbNacionalidad.Items.AddRange(new object[] {
            "Estadounidense",
            "Británica",
            "Alemana",
            "Polaca",
            "Húngara"});
            this.cmbNacionalidad.Location = new System.Drawing.Point(250, 232);
            this.cmbNacionalidad.Name = "cmbNacionalidad";
            this.cmbNacionalidad.Size = new System.Drawing.Size(170, 21);
            this.cmbNacionalidad.TabIndex = 7;
            // 
            // btnPromedioEdades
            // 
            this.btnPromedioEdades.Location = new System.Drawing.Point(250, 259);
            this.btnPromedioEdades.Name = "btnPromedioEdades";
            this.btnPromedioEdades.Size = new System.Drawing.Size(169, 19);
            this.btnPromedioEdades.TabIndex = 8;
            this.btnPromedioEdades.Text = "Promediar Edades";
            this.btnPromedioEdades.UseVisualStyleBackColor = true;
            this.btnPromedioEdades.Click += new System.EventHandler(this.btnPromedioEdades_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione una nacionalidad\r\n y haga el promedio de edad\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPromedioEdades);
            this.Controls.Add(this.cmbNacionalidad);
            this.Controls.Add(this.pcbFoto);
            this.Controls.Add(this.lblLogro);
            this.Controls.Add(this.lblOcupacion);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cmbPefil);
            this.Name = "Form1";
            this.Text = "8M";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPefil;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblOcupacion;
        private System.Windows.Forms.Label lblLogro;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.ComboBox cmbNacionalidad;
        private System.Windows.Forms.Button btnPromedioEdades;
        private System.Windows.Forms.Label label1;
    }
}

