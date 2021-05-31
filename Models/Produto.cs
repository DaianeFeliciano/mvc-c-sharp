using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; } //atalho prop cria as propriedades mais rápidas
        public string Descricao { get; set; }
        public int Quantidade { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }


    }
}
