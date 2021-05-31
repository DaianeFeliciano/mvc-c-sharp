using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace CursoMVC.Models
{
    public class Categoria
    {
        public int Id { get; set;  }

        [Display(Name = "Descrição")] // adcc propriedades na classe, todas as clases vai ter um id inteiro que será a chave primária da
        [Required(ErrorMessage = "O campo descrição é obrigatório")]                            // nossa tabela no banco de dados # modelo code first do frameork
        public string Descricao { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
