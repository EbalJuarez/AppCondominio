namespace AppCondominio
{
    partial class RegistroPropiedad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNoCasa = new System.Windows.Forms.TextBox();
            this.comboBoxDPI = new System.Windows.Forms.ComboBox();
            this.textBoxCuota = new System.Windows.Forms.TextBox();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el numero de casa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione el DPI de dueño:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese la cuota de mantenimiento:";
            // 
            // textBoxNoCasa
            // 
            this.textBoxNoCasa.Location = new System.Drawing.Point(268, 46);
            this.textBoxNoCasa.Name = "textBoxNoCasa";
            this.textBoxNoCasa.Size = new System.Drawing.Size(206, 20);
            this.textBoxNoCasa.TabIndex = 3;
            // 
            // comboBoxDPI
            // 
            this.comboBoxDPI.FormattingEnabled = true;
            this.comboBoxDPI.Location = new System.Drawing.Point(268, 101);
            this.comboBoxDPI.Name = "comboBoxDPI";
            this.comboBoxDPI.Size = new System.Drawing.Size(206, 21);
            this.comboBoxDPI.TabIndex = 4;
            // 
            // textBoxCuota
            // 
            this.textBoxCuota.Location = new System.Drawing.Point(316, 164);
            this.textBoxCuota.MaxLength = 10;
            this.textBoxCuota.Name = "textBoxCuota";
            this.textBoxCuota.Size = new System.Drawing.Size(158, 20);
            this.textBoxCuota.TabIndex = 5;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrar.Location = new System.Drawing.Point(385, 246);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(89, 31);
            this.buttonRegistrar.TabIndex = 6;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresar.Location = new System.Drawing.Point(56, 246);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(84, 31);
            this.buttonRegresar.TabIndex = 7;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // RegistroPropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 334);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.textBoxCuota);
            this.Controls.Add(this.comboBoxDPI);
            this.Controls.Add(this.textBoxNoCasa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroPropiedad";
            this.Text = "RegistroPropiedad";
            this.Load += new System.EventHandler(this.RegistroPropiedad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNoCasa;
        private System.Windows.Forms.ComboBox comboBoxDPI;
        private System.Windows.Forms.TextBox textBoxCuota;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonRegresar;
    }
}