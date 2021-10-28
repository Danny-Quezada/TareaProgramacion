using Domain.ActivoFijo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.FactoryMethod
{
    public class FactoryTipoDeActivo
    {

        public int CreateTipoDeActivo(int i)
        {
            int a = 0;
            if (i ==0)
            {
                a = 20;

            }
            else if (i == 1)
            {
                a= 5;
            }
            else if (i == 2)
            {
                a = 3;

            }
            else if (i==3)
            {
                a= 2;
            }
            else if (i == 4)
            {
                a = 1;
            }
            return a;

        }




    }
}
