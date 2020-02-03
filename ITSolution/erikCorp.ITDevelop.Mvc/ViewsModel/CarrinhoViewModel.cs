using erikCorp.ITDevelop.Domain.Carrinho;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace erikCorp.ITDevelop.Mvc.ViewsModel
{
    public class CarrinhoViewModel
    {
        public IList<Produto> produtos { get; set; }

        [Required(ErrorMessage = "O Campo {0} é Obrigatorio")]// caso o campo não for preenchido --> a interpolação com o {0} exibe o nome do campo
        [StringLength(80, ErrorMessage = "O campo {0} deve ter entr {2} e {1} caracteres", MinimumLength = 4)]// define o minimo e o maximo de caracteres em um campo

        public string mensagem { get; set; }

        [Required]
        [Range(2004, 3000, ErrorMessage = "O campo  {0 deve estar entre {1} e {2} R$")]//define o valor minimo de um capo
        public decimal valoTotal { get; set; }
    }
}
