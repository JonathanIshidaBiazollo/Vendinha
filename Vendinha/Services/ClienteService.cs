using DotNetEnv;//APAGAR ESSE TRECHO JÁ QUE O .ENV NÃO FOI ENVIADO PARA O GITHUB
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Vendinha.Contexts;
using Vendinha.Models;

namespace Vendinha.Services {
    public class ClienteService {

        private VendinhaDbContext contexto;

        //Não entendi muito bem como funciona, perguntar para o professor
        public ClienteService(VendinhaDbContext contexto) {
            this.contexto = contexto;
        }

        //****ATENÇÃO*****
        //DESCOMENTAR ESSE MÉTODO
        //public ClienteService() : this(new VendinhaDbContext(stringDeConexao))
        //{
        //}

        //****ATENÇÃO*****
        //COMENTAR OU APAGAR ESSE MÉTODO ABAIXO, USADO APENAS PARA NÃO ENVIAR MINHA SENHA PARA O GITHUB
        public ClienteService() : this(CriarContexto()) {

        }

        //****ATENÇÃO*****
        //COMENTAR OU APAGAR ESSAS LINHAS ABAIXO, USADO APENAS PARA NÃO ENVIAR MINHA SENHA PARA O GITHUB
        private static VendinhaDbContext CriarContexto() {
            Env.TraversePath().Load();

            string conexao = Environment.GetEnvironmentVariable("VENDINHA_CONEXAO")
                ?? throw new Exception("String de conexão não encontrada no .env");

            return new VendinhaDbContext(conexao);
        }


        //****ATENÇÃO*****
        //DESCOMENTAR ESSAS LINHAS ABAIXO E COLOQUE A SUA SENHA DO BANCO ONDE INDICADO
        //private const string stringDeConexao = "" +
        //    "Host=localhost;" +
        //    "Port=5432;" +
        //    "Database=vendinha" +
        //    "Username=postgres" +
        //    "Password=SUA_SENHA_AQUI";

        //Lista TODOS os clientes
        public List<Cliente> Consultar() {
            var resultado = contexto.Clientes
                .OrderBy(c => c.Nome)
                .ToList();

            return resultado;
        }

        //Lista SOMENTE os clientes que atendem as ESPECIFICAÇÕES do FILTRO
        public List<Cliente> Consultar(string pesquisa) {
            var resultado  = contexto.Clientes
                .Where(c => EF.Functions.ILike(c.Nome, $"%{pesquisa}%"))
                .OrderBy(c => c.Nome)
                .ToList();

            return resultado;
        }
        public bool Validar(Cliente cliente, out List<ValidationResult> erros){//usar o out pra retornar uma lista com os erros encontrados
            var contextoValidacao = new ValidationContext(cliente);

            erros = new List<ValidationResult>();//a lista é criada vazia, mas se houver erros, vai ser colocado onde deu o erro

            return Validator.TryValidateObject(cliente, contextoValidacao, erros, true);//retorna os erros e se o cliente passou na validação, com true or false
        }

        public bool Criar(Cliente cliente, out List <ValidationResult> erros){
            if(!Validar(cliente, out erros)) {//se apresentat retorna falso e impede o cadastro de um novo cliente, se não cadastra normalmente
                return false;
            }

            //Verificando se existe algum cpf igual já cadastrado no banco
            bool cpfExiste = contexto.Clientes
                .Any(c => c.Cpf == cliente.Cpf);

            if (cpfExiste) {
                erros.Add(new ValidationResult("CPF já cadastrado!"));
                return false;
            }

            contexto.Clientes.Add(cliente);
            contexto.SaveChanges();

            return true;
        }
    }
}
