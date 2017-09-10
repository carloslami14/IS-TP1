using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico1.Modelo;

namespace TrabajoPractico1.Interfaces
{
    interface IAgregarPaquete
    {
        void ActualizarTablaDestino(Ciudad c);
        void ActualizarTablaServicio(ServicioPaquete s);
        void ActualizarTablaPasoFronterizo(PasoFronterizo p);
    }
}
