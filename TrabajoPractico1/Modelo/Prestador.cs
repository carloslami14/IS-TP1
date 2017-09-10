using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico1.Modelo
{
    public class Prestador
    {
        public string razonSocial { get; set; }
        public string domicilio { get; set; }
        public int telefono { get; set; }
        public int cuit { get; set; }

        public Prestador(string razonSocial, string domicilio, int telefono, int cuit)
        {
            this.razonSocial = razonSocial;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.cuit = cuit;
        }
    }
}
