using CapaDatos;
using CapaNegocio;
using Entidades;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades.Interfaces;

namespace CapaPresentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            configureService(services);

            using (var ServiceProvider = services.BuildServiceProvider())
            {
                var form = ServiceProvider.GetRequiredService<frmPrincipal>();
                form.ShowDialog();
            }
        }

        private static void configureService(ServiceCollection services)
        {
            //Inyecciones para formularios
            services.AddTransient<frmPrincipal>();
            services.AddTransient<frmProducto>();
            services.AddTransient<frmListaProductos>();

            //Inyecciones para negocio
            services.AddSingleton<INegocio<clsProducto>, clsProductoNegocio>();

            //Inyecciones para datos
            services.AddSingleton<IDatos<clsProducto>, clsProductoDatos>();
        }
    }
}
