using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Vendinha.Models;

namespace Vendinha.Contexts {
    public class VendinhaDbContext : DbContext{

        //Criando a conexão com o banco de dados
        private string stringDeConexao;

        public VendinhaDbContext(string conexao) {
            this.stringDeConexao = conexao;
        }

        public VendinhaDbContext(DbContextOptions opcoes) : base(opcoes) {
            this.stringDeConexao = "";
        }

        //Pegando as informações de Clientes e dívidas
        public DbSet<Cliente> Clientes { get; set; } = null!;
        //public DbSet<Cliente> Clientes => Set<Cliente>();//Faz a mesma coisa de cima, mas achei a de cima mais fácil de entender

        public DbSet<Divida> Dividas {  get; set; } = null!;
        //public DbSet<Divida> Dividas => Set<Divida>();

        protected override void OnModelCreating(ModelBuilder construtorModelo) {
            var entidadeCliente = construtorModelo.Entity<Cliente>();

            entidadeCliente.ToTable("clientes");
            entidadeCliente.Property(c => c.Id).HasColumnName("id");
            entidadeCliente.Property(c => c.Nome).HasColumnName("nome");
            entidadeCliente.Property(c => c.Cpf).HasColumnName("cpf");
            entidadeCliente.Property(c => c.DataNascimento)
                .HasColumnName("dataNascimento")
                .HasColumnType("date");//Precisa pq usei DateTime, mas só vou salvar Date no Banco
            entidadeCliente.Property(c => c.Email).HasColumnName("email");

            entidadeCliente.HasKey(c => c.Id);
            entidadeCliente.Ignore(c => c.Idade);//Não deixar que o EntityFramework tente procurar uma coluna idade no banco
                                                 //Poderia nem colocar essa linha já que em Cliente.cs eu não coloquei o set e o EntityFrameWork não faria esse mapeamento
                                                 //Porém vou deixar para fins didáticos e para saber que caso faça uso do get e set e precise que o EF ignore algo, posso usar esse comando
            base.OnModelCreating(construtorModelo);

        }

        protected override void OnConfiguring(DbContextOptionsBuilder construtorOpcoes) {
            if(!string.IsNullOrEmpty(stringDeConexao))//Vendo se a string de conexão não está vazia ou é nula
                construtorOpcoes.UseNpgsql(stringDeConexao);//Configura o provedor Postgre com a string de conexão
            base.OnConfiguring(construtorOpcoes);//Chama a implementação da classe base,nesse caso a DbContext
        }

    }
}
