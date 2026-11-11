using Vendinha.Models;
using Vendinha.Services;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Vendinha.Desktop {
    public partial class TelaClientes : Form {
        private ClienteService servico;
        private int? idClienteEdicao = null;//o ? é para permitir o valor null nessa variável do tipo inteiro
        private int paginaAtual = 1;
        private int registrosPorPagina = 10;
        public TelaClientes() {
            InitializeComponent();

            servico = new ClienteService();

            CarregarDados();
        }

        private void CarregarDados() {
            string pesquisa  = txtPesquisar.Text;

            var totalDePaginas = (int)Math.Ceiling(servico.contarClientes(pesquisa) / (double)registrosPorPagina);

            if(paginaAtual > totalDePaginas) { //Caso eu apague o último cliente listado em uma página, para que ela não fique vazia, eu atualizo a tabela
                paginaAtual = Math.Max(1, totalDePaginas);//página atual vai ser a última, mas nunca menor que 1, para não dar erro de ir para a página 0 que não existe e dar erro no sistema
            }

            var clientes = servico.Consultar(pesquisa, paginaAtual, registrosPorPagina);

            CarregarClientes(clientes);

            lblPágina.Text = $"Página {paginaAtual} de {Math.Max(1, totalDePaginas)}";

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

            dgvClientes.ClearSelection();//Pra que o dgv não selecione automaticamente a primeira linha da tabela
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

            List<ValidationResult> erros;
            bool sucesso;

            //Ver se é cadastro ou edição
            if (idClienteEdicao == null) {
                sucesso = servico.Criar(cliente, out erros);
            } else {
                cliente.Id = idClienteEdicao.Value;
                sucesso = servico.Atualizar(cliente, out erros);
            }

            if (sucesso) {
                if (idClienteEdicao == null) {
                    MessageBox.Show("Cliente cadastrado com sucesso");
                } else {
                    MessageBox.Show("Cliente Atulizado com sucesso");
                }

                txtNome.Clear();
                mskCpf.Clear();
                txtEmail.Clear();
                dtpDataNascimento.Value = DateTime.Today;

                idClienteEdicao = null;
                btnCadastrar.Text = "Cadastrar";
                btnCancelarEdicao.Visible = false;

                CarregarDados();
            } else {
                string msg = "";

                foreach (ValidationResult erro in erros) {
                    msg += erro.ErrorMessage + "\n";
                }

                if (string.IsNullOrEmpty(msg)) {
                    msg = "Verifique se o cliente ainda existe";
                }

                MessageBox.Show(msg, "Erro, Tente Novamente");
            }
        }


        private void txtPesquisar_TextChanged(object sender, EventArgs e) {
            paginaAtual = 1;
            CarregarDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            if (dgvClientes.SelectedRows.Count == 0) {
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

            if (resposta == DialogResult.Yes) {
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

        private void TelaClientes_Shown(object sender, EventArgs e) {
            dgvClientes.ClearSelection();//Pra que o dgv não selecione automaticamente a primeira linha da tabela
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            if (dgvClientes.SelectedRows.Count == 0) {
                MessageBox.Show("Selecione um cliente para editar");
                return;
            }

            idClienteEdicao = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value);
            txtNome.Text = dgvClientes.SelectedRows[0].Cells[1].Value.ToString();
            mskCpf.Text = dgvClientes.SelectedRows[0].Cells[2].Value.ToString();
            dtpDataNascimento.Value = Convert.ToDateTime(dgvClientes.SelectedRows[0].Cells[3].Value);//Essa conversão diferente é por causa do formato DateTime
            txtEmail.Text = dgvClientes.SelectedRows[0].Cells[4].Value?.ToString() ?? "";//esses ? e "" é pq como email pode ser nulo, se de fato ele for vai causar um erro
            btnCadastrar.Text = "Salvar Alterações";
            btnCancelarEdicao.Visible = true;
        }

        private void btnCancelarEdicao_Click(object sender, EventArgs e) {
            idClienteEdicao = null;
            txtNome.Text = "";
            mskCpf.Text = "";
            txtEmail.Text = "";
            dtpDataNascimento.Value = DateTime.Today;
            btnCadastrar.Text = "Cadastrar";
            btnCancelarEdicao.Visible = false;
        }

        private void btnProximo_Click(object sender, EventArgs e) {
            var totalDePaginas = (int)Math.Ceiling(servico.contarClientes(txtPesquisar.Text) / (double)registrosPorPagina);
            if(paginaAtual <  totalDePaginas) {
                paginaAtual++;
                CarregarDados();
            }
            
        }

        private void btnAnterior_Click(object sender, EventArgs e) {
            if(paginaAtual > 1) {
                paginaAtual--;
                CarregarDados();
            }
            
        }
    }
}
