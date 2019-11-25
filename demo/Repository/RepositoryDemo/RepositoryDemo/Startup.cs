using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository;
using Sql = Repository.SqlServer;
using Csv = Repository.Csv;
using System.IO;

namespace RepositoryDemo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            #region SQL Injections

            //services.AddDbContext<Sql.SqlDbContext>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("sqlserver")));
            //services.AddTransient<IBookRepository, Sql.BookRepository>();

            #endregion

            #region CSV Injections

            services.AddTransient<IBookRepository>(x => new Csv.BookRepository($"{Directory.GetCurrentDirectory()}\\CsvFiles\\Books.csv"));

            #endregion
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
