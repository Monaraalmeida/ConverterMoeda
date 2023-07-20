using ConvertendoMoeda.Data;
using Microsoft.EntityFrameworkCore;

namespace ConvertendoMoeda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionSring = builder.Configuration.GetConnectionString("MoedaConnection");


            //Configuração da connectionstring definica no appsettings.json

            builder.Services.AddDbContext<SistemaTarefasDBContext>(opts => opts.UseMySql(connectionSring, ServerVersion.AutoDetect(connectionSring)));



            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            builder.Services.AddControllers().AddNewtonsoftJson();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}