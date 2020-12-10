using Microsoft.Extensions.DependencyInjection;
using SmartSaver.Services;
using System;
using System.Windows.Forms;



namespace SmartSaver
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginWindow());

            var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var loginWindow = serviceProvider.GetRequiredService<LoginWindow>();
                Application.Run(loginWindow);
            }
        }

        private static void ConfigureServices (ServiceCollection services)
        {
            services.AddScoped<ILoginCheckService, LoginCheckService>().AddScoped<LoginWindow>();
        }

    }
}