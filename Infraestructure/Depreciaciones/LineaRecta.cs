using Domain.ActivoFijo;
using Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Depreciaciones
{
    public class LineaRecta : IDepreciacionModel
    {
        public decimal[] Depreciar(ActivoFijo t)
        {
            decimal[] LineaRecta = new decimal[t.VidaUtil];
            for (int i = 0; i < t.VidaUtil; i++)
            {
                decimal a = (t.ValorActivo - t.ValorResidual) / t.VidaUtil;
                LineaRecta[i] = a;
            }
            return LineaRecta;
        }
    }
}
