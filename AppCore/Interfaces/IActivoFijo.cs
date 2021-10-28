using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
    public interface IActivoFijo<T>
    {

        void Create(T t);
        T[] FindAll(T t);

    }
}
