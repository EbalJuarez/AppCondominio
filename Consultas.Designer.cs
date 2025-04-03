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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReportes
            // 
            this.dataGridViewReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReportes.Location = new System.Drawing.Point(113, 86);
            this.dataGridViewReportes.Name = "dataGridViewReportes";
            this.dataGridViewReportes.Size = new System.Drawing.Size(533, 150);
            this.dataGridViewReportes.TabIndex = 0;
            // 
            // comboBoxOrden
            // 
            this.comboBoxOrden.FormattingEnabled = true;
            this.comboBoxOrden.Items.AddRange(new object[] {
            "Por cuota (Ascendente)",
            "Por cuota (Descendente)"});
            this.comboBoxOrden.Location = new System.Drawing.Point(525, 43);
            this.comboBoxOrden.Name = "comboBoxOrden";
            this.comboBoxOrden.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrden.TabIndex = 1;
            this.comboBoxOrden.Text = "Seleccione el orden";
            // 
            // buttonActualiza
            // 
            this.buttonActualiza.Location = new System.Drawing.Point(652, 43);
            this.buttonActualiza.Name = "buttonActualiza";
            this.buttonActualiza.Size = new System.Drawing.Size(75, 23);
            this.buttonActualiza.TabIndex = 2;
            this.buttonActualiza.Text = "Ordenar";
            this.buttonActualiza.UseVisualStyleBackColor = true;
            this.buttonActualiza.Click += new System.EventHandler(this.buttonActualiza_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}