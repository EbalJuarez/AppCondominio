namespace AppCondominio
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
            this.buttonPropietario = new System.Windows.Forms.Button();
            this.buttonPropiedad = new System.Windows.Forms.Button();
            this.buttonConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPropietario
            // 
            this.buttonPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPropietario.Location = new System.Drawing.Point(103, 77);
            this.buttonPropietario.Name = "buttonPropietario";
            this.buttonPropietario.Size = new System.Drawing.Size(180, 32);
            this.buttonPropietario.TabIndex = 0;
            this.buttonPropietario.Text = "Registrar Propietario";
            this.buttonPropietario.UseVisualStyleBackColor = true;
            this.buttonPropietario.Click += new System.EventHandler(this.buttonPropietario_Click);
            // 
            // buttonPropiedad
            // 
            this.buttonPropiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPropiedad.Location = new System.Drawing.Point(103, 178);
            this.buttonPropiedad.Name = "buttonPropiedad";
            this.buttonPropiedad.Size = new System.Drawing.Size(180, 30);
            this.buttonPropiedad.TabIndex = 1;
            this.buttonPropiedad.Text = "Registra propiedad";
            this.buttonPropiedad.UseVisualStyleBackColor = true;
            this.buttonPropiedad.Click += new System.EventHandler(this.buttonPropiedad_Click);
            // 
            // buttonConsulta
            // 
            this.buttonConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsulta.Location = new System.Drawing.Point(103, 274);
            this.buttonConsulta.Name = "buttonConsulta";
            this.buttonConsulta.Size = new System.Drawing.Size(180, 36);
            this.buttonConsulta.TabIndex = 2;
            this.buttonConsulta.Text = "Consultas";
            this.buttonConsulta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.buttonConsulta);
            this.Controls.Add(this.buttonPropiedad);
            this.Controls.Add(this.buttonPropietario);
            this.Name = "Form1";
            this.Text = "Administracion Condominios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPropietario;
        private System.Windows.Forms.Button buttonPropiedad;
        private System.Windows.Forms.Button buttonConsulta;
    }
}

