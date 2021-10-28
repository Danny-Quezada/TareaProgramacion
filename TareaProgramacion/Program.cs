using AppCore.Interfaces.Services;
using Autofac;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareaProgramacion.Formulario;

namespace TareaProgramacion
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var builder = new ContainerBuilder();
             builder.RegisterType<ActivoFijoModel>().As<ActivoFijoServices>();
            var container = builder.Build();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmRegistrar(container.Resolve<IActivoFijoServices>));
        }
    }
}
