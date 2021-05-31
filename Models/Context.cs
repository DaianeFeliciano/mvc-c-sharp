using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Context : DbContext // classe herda do entity framework dbcontext herda dessa interface
    {
        public DbSet<Categoria> Categorias { get; set; } // ta falando que tenho uma tabela chamada categoria quando executar
                                                         // esse context vai criar e no momento que eu precisar acessar basta referenciar esse context
            // fala para entiy que vai ter uma tabela de categoria informar qual tipo da classe e precisa deixar no startup ele visivel
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)// tem metodo dentro dele q vai subscrever metodo responsavel por configurar o entity frameork

        {
            optionsBuilder.UseSqlServer(connectionString:@"Server=(localdb)\mssqllocaldb;Database=Cursomvc;Integrated Security=True"); // string de conexão 
        }
    }
}
