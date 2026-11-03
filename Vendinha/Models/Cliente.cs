using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Vendinha.Models {
    public class Cliente {
        public int Id { get; set; }//preciso do set para o id mesmo que o banco gere o id automaticamente, pois o set pode ser usado para atribuir o valor a campos de textos por exemplo
        
        [Required(ErrorMessage="Preencha o campo nome")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome deve possuir de 2 a 100 caracteres")]
        [RegularExpression(@"^[a-zA-ZÀ-ÿ ]+$")]//acentos, espaços em branco, letras maiúsculas e minúsculas
        public string Nome {  get; set; } = "";//Para parar de dar aqueles avisos de que a propriedade precisa sair como not null do construtor

        [Required(ErrorMessage="Preencha o campo cpf")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve possuir deve ter exatamente 11 números")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Os números de CPF vão de 0 a 9")]
        public string Cpf {  get; set; } = "";

        public DateTime DataNascimento { get; set; }//Melhor pegar só a data sem horário

        [Range(18, 9999, ErrorMessage ="Clientes precisam ser maiores de 18 anos para ter uma dívida")]
        [NotMapped]//vai informar para o ENtity Framework para não armazenar no PostGre
        public int Idade {
            get {
                var hoje = DateTime.Today;
                var idade = hoje.Year - DataNascimento.Year;
                var hojeAnoNascimento = hoje.AddYears(-idade);
                if(DataNascimento > hojeAnoNascimento) {
                    idade--;
                }
                return idade;
            }
           }
        private string email = "";
        [EmailAddress(ErrorMessage="O email deve seguir esse padrão domínio@provedor.com")]
        public string Email {
            get { 
                return this.email;
            }
            set {
                if(value == null) {
                    this.email = "";//para não dar erro na função .toLower se o usuário  não digitar um email
                } else {
                    this.email = value.ToLower().Trim();
                }
            }
        }

        public List<Divida> Dividas { get; set; } = new List<Divida>();//coleção de dívidas associadas aos clientes
        
    }
}
