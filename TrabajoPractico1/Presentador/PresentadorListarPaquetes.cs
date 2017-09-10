using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico1.Interfaces;
using TrabajoPractico1.Modelo;

namespace TrabajoPractico1.Presentador
{
    class PresentadorListarPaquetes
    {
        private readonly IListarPaquetes _vista;

        public PresentadorListarPaquetes(IListarPaquetes vista)
        {
            _vista = vista;
        }

        public void CargarTabla()
        {
            _vista.CargarTabla(Repositorio.Repositorio.GetPaquetes());
        }

        public void ModificarPaquete(Paquete p)
        {

        }

        public void DesactivarPaquete(Paquete p)
        {
            foreach (Paquete pa in Repositorio.Repositorio.GetPaquetes())
            {
                if (pa.Equals(p))
                {
                    if (p.estado == EstadoPaquete.Activo)
                    {
                        pa.estado = EstadoPaquete.Inactivo;
                        _vista.Notificar("Estado Modificado a Incativo");
                        _vista.CargarTabla(Repositorio.Repositorio.GetPaquetes());
                    }
                    else
                    {
                        _vista.Notificar("No se puede modificar estado. Paquete debe ser Activo");
                    }
                }
            }
        }
    }
}
