using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCondominio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPropietario_Click(object sender, EventArgs e)
        {
            
            RegistroPropietario registroPropietario = new RegistroPropietario();
            this.Hide();
            registroPropietario.Show();
            
        }

        private void buttonPropiedad_Click(object sender, EventArgs e)
        {
            
            RegistroPropiedad registroPropiedad = new RegistroPropiedad();
            this.Hide();
            registroPropiedad.Show();
            
        }

        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas();
            this.Hide();
            consultas.Show();
            
        }
    }
}
