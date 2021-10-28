using Domain.ActivoFijo;
using Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Depreciaciones
{
    public class SDA : IDepreciacionModel
    {
        public decimal[] Depreciar(ActivoFijo t)
        {
            int Suma = 0;
            decimal[] depreciacion = new decimal[t.VidaUtil];

            for (int i = 1; i <= t.VidaUtil; i++)
            {
                Suma += i;
            }
            for (int i = 0; i < t.VidaUtil; i++)
            {
                decimal a = (i + 1) * (t.ValorActivo - t.ValorResidual);

                decimal total = a / Suma;

                depreciacion[i] = total;
            }
            return depreciacion;
        }
    }

}
