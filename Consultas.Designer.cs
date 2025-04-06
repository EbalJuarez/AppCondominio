namespace AppCondominio
{
    partial class Consultas
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
            this.dataGridViewReportes = new System.Windows.Forms.DataGridView();
            this.comboBoxOrden = new System.Windows.Forms.ComboBox();
            this.buttonActualiza = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReportes
            // 
            this.dataGridViewReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReportes.Location = new System.Drawing.Point(38, 85);
            this.dataGridViewReportes.Name = "dataGridViewReportes";
            this.dataGridViewReportes.Size = new System.Drawing.Size(533, 150);
            this.dataGridViewReportes.TabIndex = 0;
            // 
            // comboBoxOrden
            // 
            this.comboBoxOrden.FormattingEnabled = true;
            this.comboBoxOrden.Items.AddRange(new object[] {
            "Por cuota (Ascendente)",
            "Por cuota (Descendente)",
            "3 mas altas y bajas",
            "Cuota mas alta"});
            this.comboBoxOrden.Location = new System.Drawing.Point(362, 45);
            this.comboBoxOrden.Name = "comboBoxOrden";
            this.comboBoxOrden.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrden.TabIndex = 1;
            this.comboBoxOrden.Text = "Seleccione el orden";
            // 
            // buttonActualiza
            // 
            this.buttonActualiza.Location = new System.Drawing.Point(499, 43);
            this.buttonActualiza.Name = "buttonActualiza";
            this.buttonActualiza.Size = new System.Drawing.Size(75, 23);
            this.buttonActualiza.TabIndex = 2;
            this.buttonActualiza.Text = "Ordenar";
            this.buttonActualiza.UseVisualStyleBackColor = true;
            this.buttonActualiza.Click += new System.EventHandler(this.buttonActualiza_Click);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(499, 255);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegresar.TabIndex = 3;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 323);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.buttonActualiza);
            this.Controls.Add(this.comboBoxOrden);
            this.Controls.Add(this.dataGridViewReportes);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReportes;
        private System.Windows.Forms.ComboBox comboBoxOrden;
        private System.Windows.Forms.Button buttonActualiza;
        private System.Windows.Forms.Button buttonRegresar;
    }
}