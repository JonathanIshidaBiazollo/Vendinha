using Vendinha.Models;
using Vendinha.Services;
using System.ComponentModel.DataAnnotations;

namespace Vendinha.Desktop {
    public partial class TelaClientes : Form {
        public TelaClientes() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void lblTitulo_Click(object sender, EventArgs e) {

        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            Cliente cliente = new Cliente{
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
            } else {
                string msg = "";

                foreach (ValidationResult erro in erros) {
                    msg += erro.ErrorMessage + "\n";
                }

                MessageBox.Show(msg, "Erro de validação, tente novamente");
            }
        }
    }
}
