using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Vendinha.Models {
    public class Cliente {
        public int Id { get; set; }//preciso do set para o id mesmo que o banco gere o id automaticamente, pois o set pode ser usado para atribuir o valor a campos de textos por exemplo
        
        [Required]
        [StringLength(100, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-ZÀ-ÿ ]+$")]//acentos, espaços em branco, letras maiúsculas e minúsculas
        public string Nome {  get; set; } = "";//Para parar de dar aqueles avisos de que a propriedade precisa sair como not null do construtor

        [Required]
        [StringLength(11, MinimumLength = 11)]
        [RegularExpression(@"^\d{11}$")]
        public string Cpf {  get; set; } = "";

        public DateTime DataNascimento { get; set; }//Melhor pegar só a data sem horário

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
        [EmailAddress]
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
        
    }
}
