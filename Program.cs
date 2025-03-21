using System;
using System.Net;
using System.Security.Cryptography;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;

// dotnet add package Microsoft.Aspnetcore.Hosting
// dotnet add package microsoft.extensions.hosting
// dotnet add package Microsoft.AspnetCore.App

namespace ASPNET
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var Builder = WebApplication.CreateBuilder(args); // Criar a aplicação
            var app = Builder.Build(); // Configurar 

            app.UseStaticFiles();  // Para poder aplicar arquivos estaticos

            app.UseRouting();

            // Para definir as rotas
            app.UseEndpoints(endpoints =>{
               endpoints.MapGet("/", async context => {
                    context.Response.Redirect("/index.html");
               });
            });

            app.Run();
        }

    }
}