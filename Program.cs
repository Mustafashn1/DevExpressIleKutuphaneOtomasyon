using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;


namespace deneme12
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Service collection
            var services = new ServiceCollection();
            services.AddDbContext<Context>(options =>
                options.UseNpgsql(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString));

            // Resolve dependencies
            var serviceProvider = services.BuildServiceProvider();
            var dbContext = serviceProvider.GetRequiredService<Context>();

            // Run the application
            Application.Run(new Form1(dbContext)); // DbContext'i Form1'e geçiriyoruz
        }
    }
}
