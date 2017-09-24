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

        public Paquete ModificarPaquete(Paquete p)
        {
            foreach (Paquete pa in Repositorio.Repositorio.GetPaquetes())
            {
                if (pa.Equals(p))
                {
                    return pa;
                }
            }

            return null;
        }

        public void ModificarEstadoPaquete(Paquete p)
        {
            foreach (Paquete pa in Repositorio.Repositorio.GetPaquetes())
            {
                if (pa.Equals(p))
                {
                    _vista.ModificarPaquete(pa.nombre);
                }
            }
        }

        public void GuardarPaquete(string nombre, int estado)
        {
            foreach (Paquete pa in Repositorio.Repositorio.GetPaquetes())
            {
                if (pa.nombre == nombre)
                {
                    switch (estado)
                    {
                        case (int)EstadoPaquete.Activo:
                            pa.estado = EstadoPaquete.Activo;
                            break;
                        case (int)EstadoPaquete.Creado:
                            pa.estado = EstadoPaquete.Creado;
                            break;
                        case (int)EstadoPaquete.Inactivo:
                            pa.estado = EstadoPaquete.Inactivo;
                            break;
                    }
                    _vista.CargarTabla(Repositorio.Repositorio.GetPaquetes());
                    _vista.Notificar("Estado de Paquete Modificado");
                }
            }
        }
    }
}
