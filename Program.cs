using Microsoft.AspNetCore.Identity;
using PrimeiroProjetoBanco.Data;
using PrimeiroProjetoBanco.Models;
using PrimeiroProjetoBanco.Repository;
using PrimeiroProjetoBanco.Repository.Interfaces;

namespace PrimeiroProjetoBanco
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Neste momento, o AppDbContext estará disponível para todas
            // as classes que o usarem, através de injeção de dependência.
            builder.Services.AddDbContext<AppDbContext>();
            builder.Services.AddTransient<IPessoaRepository, PessoaRepository>();
            //builder.Services.AddTransient<IEndereco, Endereco>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}