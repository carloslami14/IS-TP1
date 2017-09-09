using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1.Modelo
{
    public class Provincia
    {
        public string nombre { get; set; }
        public List<Ciudad> ciudades { get; set; }
        public Pais pais { get; set; }

        public Provincia(string nombre, Pais pais)
        {
            this.nombre = nombre;
            this.pais = pais;
            ciudades = new List<Ciudad>();
        }

        public void AgregarCiudades(Ciudad c)
        {
            ciudades.Add(c);
        }
    }
}
