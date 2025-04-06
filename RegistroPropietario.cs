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
    public partial class RegistroPropietario : Form
    {
        List<Propietario> Lista_Propietarios = new List<Propietario>();
        
        Guardados Guardados = new Guardados();
        public RegistroPropietario()
        {
            InitializeComponent();
        }
        private void clear()
        {
            textBoxApellido.Text = string.Empty;
            textBoxNombre.Text = string.Empty;
            textBoxDPI.Text = string.Empty;
            
        }
        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            Propietario propietario = new Propietario();
            propietario.Nombre = textBoxNombre.Text;
            propietario.Apellido = textBoxApellido.Text;
            propietario.Dpi = int.Parse(textBoxDPI.Text);
            clear();
            Lista_Propietarios.Add(propietario);
            Guardados.GuardarPropietario("../../Registro_Propietarios", Lista_Propietarios);
        }

        private void RegistroPropietario_Load(object sender, EventArgs e)
        {
            Lista_Propietarios = Guardados.LeerPropietario("../../Registro_Propietarios");
        }
    }
}
