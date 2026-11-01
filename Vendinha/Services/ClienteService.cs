using System;
using System.Collections.Generic;
using System.Text;
using Vendinha.Contexts;
using Vendinha.Models;
using DotNetEnv;//APAGAR ESSE TRECHO JÁ QUE O .ENV NÃO FOI ENVIADO PARA O GITHUB

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

        public List<Cliente> Consultar() {
            var resultado = contexto.Clientes
                .OrderBy(c => c.Nome)
                .ToList();

            return resultado;
        }

    }
}
