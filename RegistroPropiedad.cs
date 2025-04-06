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
    public partial class RegistroPropiedad : Form
    {
        
        List<Propietario> Lista_Propietarios = new List<Propietario>();
        List<Propiedad> Lista_Propiedades = new List<Propiedad>();
        Guardados Guardados = new Guardados();
        public RegistroPropiedad()
        {
            InitializeComponent();
        }

        private void Rellenar_Combox() {
            Lista_Propietarios = Guardados.LeerPropietario("../../Registro_Propietarios");
            foreach (var propiedad in Lista_Propietarios) {
                comboBoxDPI.Items.Add(propiedad.Dpi);
            }
        }

        

        private void clear() {
            textBoxCuota.Text = string.Empty;
            textBoxNoCasa.Text = string.Empty;
        }
        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            Propiedad propiedad = new Propiedad();
            propiedad.Cuota = float.Parse(textBoxCuota.Text);
            propiedad.NoCasa = int.Parse(textBoxNoCasa.Text);
            propiedad.Dpi = int.Parse(comboBoxDPI.SelectedItem.ToString());
            Lista_Propiedades.Add(propiedad);
            Guardados.GuardarPropiedad("../../Registro_Propiedad", Lista_Propiedades);
            clear();
        }

        private void RegistroPropiedad_Load(object sender, EventArgs e)
        {
            clear();
            Lista_Propiedades = Guardados.LeerPropiedad("../../Registro_Propiedad");
            Rellenar_Combox();
        }
    }
}
