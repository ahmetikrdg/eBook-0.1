using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EBook.Business.Abstract;
using EBook.Business.Concrate;
using EBook.Data.Abstract;
using EBook.Data.Concrate.EfCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EBook
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IBookRepository, EfCoreBookRepository>();
            services.AddScoped<IBookService, BookManager>();

            services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();
            services.AddScoped<ICategoryService, CategoryManager>();

            services.AddScoped<IAuthorRepository, EfCoreAuthorRepository>();
            services.AddScoped<IAuthorServices, AuthorManager>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                      name: "kitaplisteleri",
                      pattern: "Yazarlar/{page?}",
                      defaults: new { controller = "Home", action = "AuthorList" }
                      );

                endpoints.MapControllerRoute(
                       name: "kitap",
                       pattern: "Yazarlar/YazarAdý/{Yurl}",
                       defaults: new { Controller = "home", action = "AuthorDetail" }
                   );
                //-- kitaplar
                endpoints.MapControllerRoute(
                     name: "bookread",
                     pattern: "Okuma/{id}",
                     defaults: new { Controller = "home", action = "BookRead" }
                 );
                endpoints.MapControllerRoute(
                       name: "kitaplisteleri",
                       pattern: "kitap/{category?}/{page?}",
                       defaults: new { controller = "Home", action = "BookList" }
                       );
                endpoints.MapControllerRoute(
                       name: "kitap",
                       pattern: "eBook/KitapAdý/{Url}",
                       defaults: new { Controller = "home", action = "BookDetails" }
                   );
               

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
