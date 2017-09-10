using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1.Modelo
{
    public class Ciudad
    {
        public string nombre { get; set; }
        public Provincia provincia { get; set; }
        
        public string _provincia { get { return GetNombreProvincia(); } }
        public string _pais { get { return GetNombrePais(); } }

        public Ciudad(string nombre, Provincia provincia)
        {
            this.nombre = nombre;
            this.provincia = provincia;
        }

        private string GetNombreProvincia()
        {
            return provincia.nombre;
        }

        private string GetNombrePais()
        {
            return provincia.pais.nombre;
        }

        public override string ToString()
        {
            return nombre + ", " + provincia.nombre + ", " + provincia.pais.nombre;
        }
    }
}
