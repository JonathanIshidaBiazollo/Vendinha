using Vendinha.Models;
using Vendinha.Services;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Vendinha.Desktop {
    public partial class TelaClientes : Form {
        private ClienteService servico;

        public TelaClientes() {
            InitializeComponent();

            servico = new ClienteService();

            CarregarDados();
        }

        private void CarregarDados() {
            var clientes = servico.Consultar();
            CarregarClientes(clientes);
        }
        private void CarregarClientes(List<Cliente> lista) {
            dgvClientes.Rows.Clear();

            foreach (var cliente in lista) {
                dgvClientes.Rows.Add(
                    cliente.Id,
                    cliente.Nome,
                    cliente.Cpf,
                    cliente.DataNascimento.ToString("dd/MM/yyyy"),
                    cliente.Email
                );
            }
        }
        private void Form1_Load(object sender, EventArgs e) {

        }

        private void lblTitulo_Click(object sender, EventArgs e) {

        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            Cliente cliente = new Cliente {
                Nome = txtNome.Text,
                Cpf = mskCpf.Text,
                DataNascimento = dtpDataNascimento.Value.Date,
                Email = txtEmail.Text
            };

            ClienteService servico = new ClienteService();
            List<ValidationResult> erros;
            bool cadastrado = servico.Criar(cliente, out erros);

            if (cadastrado) {
                MessageBox.Show("Cliente Cadastrado com sucesso");

                txtNome.Clear();
                mskCpf.Clear();
                txtEmail.Clear();
                dtpDataNascimento.Value = DateTime.Today;

                CarregarDados();
            } else {
                string msg = "";

                foreach (ValidationResult erro in erros) {
                    msg += erro.ErrorMessage + "\n";
                }

                MessageBox.Show(msg, "Erro de validação, tente novamente");
            }
        }


        private void txtPesquisar_TextChanged(object sender, EventArgs e) {
            var resultado = servico.Consultar(txtPesquisar.Text);

            CarregarClientes(resultado);
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            if(dgvClientes.SelectedRows.Count == 0) {
                MessageBox.Show("Selecione um cliente para excluir");
                return;
            }

            int id = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value);
            var resposta = MessageBox.Show(
                "Deseja realmente excluir o cliente selecionado?",
                "Confirma a exclusão?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if(resposta == DialogResult.Yes) {
                bool excluido = servico.Excluir(id);

                if (excluido) {
                    MessageBox.Show("Cliente excluído com sucesso");
                    CarregarDados();
                } else {
                    MessageBox.Show("Não foi possível excluir o cliente,\n" +
                                    "Ele possuí dívidas cadastradas\n" +
                                    "Ou não existe mais"
                                    );
                }
            }
        }
    }
}
