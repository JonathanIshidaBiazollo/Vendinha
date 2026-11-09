using DotNetEnv;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Vendinha.Contexts;
using Vendinha.Models;

namespace Vendinha.Services {
    public class DividaService {
        private VendinhaDbContext contexto;

        public DividaService(VendinhaDbContext contexto) {
            this.contexto = contexto;
        }

        //****ATENÇÃO*****
        //COMENTAR OU APAGAR ESSE MÉTODO ABAIXO, USADO APENAS PARA NÃO ENVIAR MINHA SENHA PARA O GITHUB
        public DividaService() : this(CriarContexto()) {

        }

        //****ATENÇÃO*****
        //COMENTAR OU APAGAR ESSAS LINHAS ABAIXO, USADO APENAS PARA NÃO ENVIAR MINHA SENHA PARA O GITHUB
        private static VendinhaDbContext CriarContexto() {
            Env.TraversePath().Load();

            string conexao = Environment.GetEnvironmentVariable("VENDINHA_CONEXAO")
                ?? throw new Exception("String de conexão não encontrada no .env");

            return new VendinhaDbContext(conexao);
        }

        public bool Validar(Divida divida, out List<ValidationResult> erros) {
            var contextoValidacao = new ValidationContext(divida);

            erros = new List<ValidationResult>();

            return Validator.TryValidateObject(divida, contextoValidacao, erros, true);
        }
        public bool Criar(Divida divida, out List<ValidationResult> erros) {
            if (!Validar(divida, out erros)) {
                return false;
            }

            bool idExiste = contexto.Clientes
                .Any(c => c.Id == divida.ClienteId);

            if(!idExiste) { 
                erros.Add(new ValidationResult("Cliente não encontrado"));
                return false;
            }

            bool dividaAtiva = contexto.Dividas
                .Any(d => d.ClienteId == divida.ClienteId && d.Paga == false);

            if (dividaAtiva) {
                erros.Add(new ValidationResult("Cliente possui dívida ativa, impossível cadastrar outras"));
                return false;
            }

            //Fazer com que toda dívida comece como NÂO paga
            divida.Paga = false;
            divida.DataCriacao = DateTime.Today;
            divida.DataPagamento = null;

            contexto.Dividas.Add(divida);
            contexto.SaveChanges();

            return true;
        }
    }
}
