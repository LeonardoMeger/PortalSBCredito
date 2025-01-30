using Domain.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //builder.Services.AddDbContext<PortalContext>(options =>
            //    options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")));
            builder.Services.AddDbContext<PortalContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"),
                b => b.MigrationsAssembly("WebAPI")));

            builder.Services.AddScoped<TituloRepository>();
            builder.Services.AddScoped<OperationRepository>();
            // Adicionar serviços ao contêiner.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.AddCors(opstions => 
            {
                opstions.AddPolicy("PortalApp", builder =>  
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });

            var app = builder.Build();

            // Configurar o pipeline de requisição HTTP.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("PortalApp");

            app.UseAuthorization();

            // Mapeia a rota principal para redirecionar à controller Titulo.
            app.MapGet("/", () => Results.Redirect("/api/Titulo"));

            // Mapear os controllers.
            app.MapControllers();

            // Executar o app.
            app.Run();
        }
    }
}
