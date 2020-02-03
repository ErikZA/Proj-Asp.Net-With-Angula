using erikCorp.ITDevelop.Data.ORM;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace erikCorp.ITDevelop.Mvc
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ITDevelopDataContext>(options => 
                options.UseSqlServer( Configuration.GetConnectionString("DefaulITDevelop")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=painel}/{action=Index}/{id?}");

                //este é um indice de rotas, apos o componente ser criado e as views serem criadas é possvel estabelecer uma
                // rota especifica para ela.
                //Mal habito (NÃO RECOMENDADO)
            //    //O correto e definir a rota direto na classe controladora.
            //    routes.MapRoute(
            //       name: "Produtos",
            //       template: "{controller=Produto}/{action=Listagem}");
            });
        }
    }
}
