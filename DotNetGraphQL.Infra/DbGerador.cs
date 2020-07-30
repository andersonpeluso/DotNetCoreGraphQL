using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace DotNetGraphQL.Infra
{
    public class DbGerador
    {
        /// <summary>
        /// Inicia banco em memória
        /// </summary>
        public static void Iniciar(IServiceProvider serviceProvider)
        {
            using (var contexto = new ExemploContext(serviceProvider.GetRequiredService<DbContextOptions<ExemploContext>>()))
            {
                if (contexto.Usuarios.Any())
                    return;   // Dados ja foram providos

                contexto.Usuarios.AddRange(
                    new Usuario()
                    {
                        Id = 1,
                        Email = "Maria@teste.com.br",
                        Idade = 18,
                        Nome = "Maria Maria",
                        DataCriacao = new DateTime(2019, 7, 7, 9, 50, 20)
                    },
                    new Usuario()
                    {
                        Id = 2,
                        Email = "sreais@teste.com.br",
                        Idade = 31,
                        Nome = "Sidnei Reis",
                        DataCriacao = new DateTime(2019, 7, 12, 9, 53, 12)
                    },
                    new Usuario()
                    {
                        Id = 3,
                        Email = "rrisso@teste.com.br",
                        Idade = 31,
                        Nome = "Rafael Risso",
                        DataCriacao = new DateTime(2019, 7, 7, 9, 55, 56),
                        DataAlteracao = new DateTime(2019, 7, 20, 9, 23, 20)
                    }
                    );
                contexto.SaveChanges();
            }
        }
    }
}