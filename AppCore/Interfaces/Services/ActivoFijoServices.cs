using Domain.ActivoFijo;
using Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces.Services
{
    public class ActivoFijoServices : IActivoFijo<ActivoFijo>
    {
        private IActivoFijoModel Activo;

        public ActivoFijoServices(IActivoFijoModel activo)
        {
            this.Activo = activo;
        }
        public void Create(ActivoFijo t)
        {
             Activo.Create(t);
        }

        public ActivoFijo[] FindAll(ActivoFijo t)
        {
            return Activo.FindAll(t);
        }
    }
}
