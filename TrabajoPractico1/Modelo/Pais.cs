using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1.Modelo
{
    public class Pais
    {
        public string nombre { get; set; }
        public List<Provincia> provincias { get; set; }

        public Pais(string nombre)
        {
            this.nombre = nombre;
            provincias = new List<Provincia>();
        }

        public void AgregarProvincia(Provincia p)
        {
            provincias.Add(p);
        }
    }
}
