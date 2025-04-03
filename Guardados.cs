using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppCondominio
{
    internal class Guardados
    {
        public void GuardarPropiedad(string archivo, List<Propiedad> asistencias)
        {
            string json = JsonConvert.SerializeObject(asistencias);
            System.IO.File.WriteAllText(archivo, json);
        }

        public List<Propiedad> LeerPropiedad(string archivo)
        {
            List<Propiedad> lista = new List<Propiedad>();
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Propiedad>>(json);
            return lista;
        }

        public void GuardarPropietario(string archivo, List<Propietario> asistencias)
        {
            string json = JsonConvert.SerializeObject(asistencias);
            System.IO.File.WriteAllText(archivo, json);
        }

        public List<Propietario> LeerPropietario(string archivo)
        {
            List<Propietario> lista = new List<Propietario>();
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Propietario>>(json);
            return lista;
        }
    }
}
