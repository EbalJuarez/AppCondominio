using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        List<Reporte> ReporteConsultas = new List<Reporte>();
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
            if (opc == "Por cuota (Ascendente)") {
                Rellenar_Data();
                Reportes.Sort((a1, a2) => a1.Cuota.CompareTo(a2.Cuota));
                dataGridViewReportes.DataSource = null;
                dataGridViewReportes.DataSource = Reportes;
                dataGridViewReportes.Refresh();
            }
            if (opc == "Por cuota (Descendente)")
            {
                Rellenar_Data();
                Reportes = Reportes.OrderByDescending(a => a.Cuota).ToList();
                dataGridViewReportes.DataSource = null;
                dataGridViewReportes.DataSource = Reportes;
                dataGridViewReportes.Refresh();
            }
            if (opc == "Cuotas mas Altas / Bajas")
            {
                Rellenar_Data();
                Reportes = Reportes.OrderByDescending(a => a.Cuota).ToList();
                ReporteConsultas.Add(Reportes[0]);
                ReporteConsultas.Add(Reportes[1]);
                ReporteConsultas.Add(Reportes[2]);
                ReporteConsultas.Add(Reportes[Reportes.Count-2]);
                ReporteConsultas.Add(Reportes[Reportes.Count-1]);
                ReporteConsultas.Add(Reportes[Reportes.Count]);
                dataGridViewReportes.DataSource = null;
                dataGridViewReportes.DataSource = ReporteConsultas;
                dataGridViewReportes.Refresh();
            }
            if (opc == "Cuota mas alta")
            {
                Rellenar_Data();
                Reportes.OrderByDescending(a => a.Cuota).First();
                dataGridViewReportes.DataSource = null;
                dataGridViewReportes.DataSource = Reportes;
                dataGridViewReportes.Refresh();
            }
           
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();  
            form1.Show();

        }
    }
}
