using Domain.ActivoFijo;
using Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces.Services
{
    public class ServicesMetodos : IDepreciacion<ActivoFijo>
    {
        private IDepreciacionModel Model;
        public ServicesMetodos(IDepreciacionModel model)
        {
            this.Model = model;
        }
        public decimal[] Depreciar(ActivoFijo t)
        {
            return Model.Depreciar(t);
        }
    }
}
