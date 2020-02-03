using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace erikCorp.ITDevelop.Domain.Carrinho
{
    public class Produto
    {
        public Produto()
        {
            this.id = Guid.NewGuid();
        }

        [Key]// reforça que esse campo é chave primaria
        public Guid id { get; set; }

        [Display(Name = "Noem Do Produto")] //Torna a exibição mais agradavel
        [Required(ErrorMessage ="O Campo {0} é Obrigatorio")]// caso o campo não for preenchido --> a interpolação com o {0} exibe o nome do campo
        [StringLength(80,ErrorMessage ="O campo {0} deve ter entr {2} e {1} caracteres",MinimumLength = 4)]// define o minimo e o maximo de caracteres em um campo
        public string nome { get; set; }
        
        
        [Display(Name = "Valor do Produto")]
        [Required]//define que existe uma regra para o campo
        [Range(1,3000,ErrorMessage ="O campo  {0 deve estar entre {1} e {2} R$")]//define o valor minimo de um capo
        public decimal valor { get; set; }
        
        
        public bool temEstoque { get; set; }


        [Display(Name ="Validade do Produto", Description ="Selecione uma data futura")]
        [Required]
        [DataType(DataType.Date, ErrorMessage ="Data Invalida")]// definindo que o campo so aceita uma data
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]// definindo o formato de data valida
        public DateTime data { get; set; }  
    }
}
