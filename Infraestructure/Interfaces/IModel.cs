using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public interface IModel<T>
    {

        void Create(T t);
        T[] FindAll(T t);

    }
}
