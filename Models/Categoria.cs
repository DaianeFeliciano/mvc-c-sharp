using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CursoMVC.Models
{
    public class Categoria
    {
        public int Id { get; set;  }// adcc propriedades na classe, todas as clases vai ter um id inteiro que será a chave primária da
                                    // nossa tabela no banco de dados # modelo code first do frameork
        public string Descricao { get; set; }
    }
}
