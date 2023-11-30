using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace YourNamespace
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Este método é chamado durante a execução. Use este método para adicionar serviços ao contêiner.
        public void ConfigureServices(IServiceCollection services)
        {
            // Configuração do serviço de autenticação
            services.AddAuthentication("CookieAuth")
                .AddCookie("CookieAuth", config =>
                {
                    config.Cookie.Name = "YourApp.Cookie";
                    config.LoginPath = "/Account/Login";
                });

            // Configuração da autorização
            services.AddAuthorization(config =>
            {
                config.AddPolicy("Manager", policy =>
                {
                    policy.RequireRole("Manager");
                });
            });

            // Outros serviços e configurações podem ser adicionados aqui
        }

        // Este método é chamado durante a execução. Use este método para configurar o pipeline de solicitação.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            // Outras configurações de middleware podem ser adicionadas aqui

            app.UseRouting();

            // Habilita a autenticação e a autorização
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
