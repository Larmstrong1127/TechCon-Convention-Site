using LandonWebsite06.Data;
using LandonWebsite06.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LandonWebsite06
{
    /// <summary>
    /// Configures services (dependency injection) and the HTTP request pipeline.
    /// </summary>
    public class Startup
    {
        // Register application services with the DI container
        public void ConfigureServices(IServiceCollection services)
        {
            // SQLite database for convention data (companies, guests)
            services.AddDbContext<MyDBContext>(options =>
                options.UseSqlite("Data Source=Event.db"));

            services.AddMvc(options => options.EnableEndpointRouting = false);

            // ICompanyData provides an in-memory list used by some views;
            // the controller primarily uses the DbContext directly
            services.AddSingleton<ICompanyData, CompanyData>();
        }

        // Configure the HTTP request pipeline middleware
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, MyDBContext database)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            // Seed the database with initial data on first run only.
            // EnsureCreated is safe to call repeatedly — it only creates if missing.
            database.Database.EnsureCreated();

            app.UseStaticFiles();

            // MVC routing: convention-based default route
            app.UseMvcWithDefaultRoute();
        }
    }
}
