using Domain.ActivoFijo;
using Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class ActivoFijoModel :IActivoFijoModel
    {
        private ActivoFijo[] activos { get; set; }
        public void Create(ActivoFijo t)
        {
            if (activos == null)
            {
                activos = new ActivoFijo[1];
                activos[0] = t;
            }
            else
            {
                ActivoFijo[] temp = new ActivoFijo[activos.Length + 1];
                Array.Copy(activos, temp, activos.Length);
                temp[temp.Length - 1] = t;
                activos = temp;
            }
        }

        public ActivoFijo[] FindAll(ActivoFijo t)
        {
            return activos;
        }

        
    }
}
