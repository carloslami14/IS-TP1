using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico1.Interfaces;
using TrabajoPractico1.Modelo;

namespace TrabajoPractico1.Presentador
{
    class PresentadorListarSalidas
    {
        private readonly IListarSalidas _vista;

        public PresentadorListarSalidas(IListarSalidas vista)
        {
            _vista = vista;
        }

        public void CargarTabla()
        {
            foreach (Salida sal in Repositorio.Repositorio.GetSalidas())
            {
                if (sal.fecha <= DateTime.Today)
                {
                    if (sal.estado == EstadoSalida.EnVenta)
                    {
                        sal.estado = EstadoSalida.EnEjecucion;
                    }
                }
                if ((sal.fecha.AddDays(sal.paquete.cantDias)) <= DateTime.Now)
                {
                    if (sal.estado == EstadoSalida.EnEjecucion)
                    {
                        sal.estado = EstadoSalida.Finalizada;
                    }
                }
            }
            _vista.CargarTabla(Repositorio.Repositorio.GetSalidas());
        }

        public void DesactivarSalida(Salida sal)
        {
            foreach (Salida a in Repositorio.Repositorio.GetSalidas())
            {
                if (sal.numero == a.numero)
                {
                    if (a.estado == EstadoSalida.EnVenta)
                    {
                        a.estado = EstadoSalida.EnPausa;
                        _vista.CargarTabla(Repositorio.Repositorio.GetSalidas());
                        _vista.Notificar("Estado Modificado a EnPausa");
                    }
                    else
                    {
                        _vista.Notificar("No se puede modificar salida, tiene que tener Estado: EnVenta");
                    }
                }
            }
        }
    }
}
