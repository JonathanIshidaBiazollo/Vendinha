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
            //Mapeando Cliente
            var entidadeCliente = construtorModelo.Entity<Cliente>();

            entidadeCliente.ToTable("clientes");
            entidadeCliente.Property(c => c.Id).HasColumnName("id");
            entidadeCliente.Property(c => c.Nome).HasColumnName("nome");
            entidadeCliente.Property(c => c.Cpf).HasColumnName("cpf");
            entidadeCliente.Property(c => c.DataNascimento)
                .HasColumnName("dataNascimento")
                .HasColumnType("date");//Precisa pq usei DateTime, mas só vou salvar Date no Banco
                                        //Poderia usar DateOnly tbm pra não precisar especidifcar isso aqui, porém
                                        //na hora de usar o DateTimePicker, vou precisar converter o valor dele tbm,
                                        //se fizer isso aqui agora não preciso converter o que vem desse componente
            entidadeCliente.Property(c => c.Email).HasColumnName("email");

            //Identificação da chave Pimária
            entidadeCliente.HasKey(c => c.Id);
            entidadeCliente.Ignore(c => c.Idade);//Não deixar que o EntityFramework tente procurar uma coluna idade no banco
                                                 //Poderia nem colocar essa linha já que em Cliente.cs eu não coloquei o set e o EntityFrameWork não faria esse mapeamento
                                                 //Porém vou deixar para fins didáticos e para saber que caso faça uso do get e set e precise que o EF ignore algo, posso usar esse comando
            

            //Mapeando Dívida
            var entidadeDivida = construtorModelo.Entity<Divida>();

            entidadeDivida.ToTable("dividas");
            entidadeDivida.Property(d => d.Id).HasColumnName("id");
            entidadeDivida.Property(d => d.Valor).HasColumnName("valor");
            entidadeDivida.Property(d => d.Paga).HasColumnName("paga");

            entidadeDivida.Property(d => d.DataCriacao)
                .HasColumnName("dataCriacao")
                .HasColumnType("date");

            entidadeDivida.Property(d => d.DataPagamento)
                .HasColumnName("dataPagamento")
                .HasColumnType("date");

            //Chave Estrangeira
            entidadeDivida.Property(d => d.ClienteId).HasColumnName("clienteId");

            //Chave Primária
            entidadeDivida.HasKey(d => d.Id);

            //Cliente pode ter várias dívidas, mas uma dívida é somente de um cliente
            //como representar no EF
            entidadeDivida
                .HasOne(d => d.Cliente)//1 dívida possui 1 cliente
                .WithMany(c => c.Dividas)//1 cliente pode possuir várias dívidas
                .HasForeignKey(d => d.ClienteId);//Indicando a chave estrangeira para cruzar a referência

            base.OnModelCreating(construtorModelo);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder construtorOpcoes) {
            if(!string.IsNullOrEmpty(stringDeConexao))//Vendo se a string de conexão não está vazia ou é nula
                construtorOpcoes.UseNpgsql(stringDeConexao);//Configura o provedor Postgre com a string de conexão
            base.OnConfiguring(construtorOpcoes);//Chama a implementação da classe base,nesse caso a DbContext
        }

    }
}
