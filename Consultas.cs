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
    public partial class Consultas : Form
    {
        Reporte Reporte = new Reporte();
        List<Propiedad> Lista_Propiedad = new List<Propiedad>();
        List<Propietario> Lista_Propietario = new List<Propietario>();
        List<Reporte> Reportes = new List<Reporte>();
        Propiedad Propiedad = new Propiedad();
        Propietario propietario = new Propietario();
        Guardados Guardados = new Guardados();
        public Consultas()
        {
            InitializeComponent();
        }

        private void Cargar() {
            Lista_Propietario = Guardados.LeerPropietario("../../Registro_Propietarios");
            Lista_Propiedad = Guardados.LeerPropiedad("../../Registro_Propiedad");
        }

        private void Rellenar_Data() {
            Cargar();
            foreach (var propietario in Lista_Propietario) {
                foreach (var propiedad in Lista_Propiedad) {
                    Reporte.Nombre = propietario.Nombre;
                    Reporte.Apellido = propietario.Apellido;
                    if (propietario.Dpi == propiedad.Dpi) { 
                        Reporte.NoCasa = propiedad.NoCasa;
                        Reporte.Cuota = propiedad.Cuota;
                    }

                    Reportes.Add(Reporte);
                }
            }
            dataGridViewReportes.DataSource = null;
            dataGridViewReportes.DataSource = Reportes;
            dataGridViewReportes.Refresh();
        }
        private void Consultas_Load(object sender, EventArgs e)
        {
            Rellenar_Data();
        }

        private void buttonActualiza_Click(object sender, EventArgs e)
        {
            string opc;
            opc = comboBoxOrden.SelectedItem.ToString();
            if (opc == "Por cuota (Ascendente) ") { 
                
            }
            if (opc == "Por cuota (Descendente) ")
            {
                Reportes = Reportes.OrderByDescending(a => a.Cuota).ToList();
            }
        }
    }
}
