using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Vendinha.Services;
using Vendinha.Models;

namespace Vendinha.Desktop.Screen {
    public partial class TelaDividas : Form {
        private ClienteService servicoClientes;
        private DividaService servicoDivida;
        private int paginaAtual = 1;
        private int registrosPorPagina = 10;
        public TelaDividas() {
            InitializeComponent();

            servicoClientes = new ClienteService();
            servicoDivida = new DividaService();

            CarregarClientes();

        }

        private void CarregarClientes(string pesquisa = "") {
            var clientes = servicoClientes.Consultar();
            clientes = clientes
                .Where(c => c.Nome.Contains(pesquisa, StringComparison.OrdinalIgnoreCase))
                .ToList();

            clientes.Insert(0, new Cliente {
                Id = 0,
                Nome = "Todos os clientes"
            });

            cmbClientes.DataSource = clientes;
            cmbClientes.DisplayMember = "Nome";
            cmbClientes.ValueMember = "Id";
        }

        private void CarregarDividas() {
            dgvDividas.Rows.Clear();

            if (cmbClientes.SelectedValue == null) {
                return;
            }

            int clienteId = Convert.ToInt32(cmbClientes.SelectedValue);

            int totalDePaginas = (int)Math.Ceiling(servicoDivida.ContarDividas(clienteId) / (double)registrosPorPagina);

            if (paginaAtual > totalDePaginas) {
                paginaAtual = Math.Max(1, totalDePaginas);
            }

            var dividas = servicoDivida.Consultar(clienteId, paginaAtual, registrosPorPagina);

            foreach (var divida in dividas) {
                dgvDividas.Rows.Add(
                    divida.Id,
                    divida.Cliente.Nome,
                    divida.Valor.ToString("C2"),//Para alterar a formatação para a moeda corrente do sistema
                    divida.Paga ? "Paga" : "Não Paga",
                    divida.DataCriacao.ToString("dd/MM/yyyy"),
                    divida.DataPagamento?.ToString("dd/MM/yyyy") ?? "-"
                );
            }

            lblPagina.Text = $"Página {paginaAtual} de {Math.Max(1, totalDePaginas)}";

            dgvDividas.ClearSelection();
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            if (cmbClientes.SelectedValue == null) {
                MessageBox.Show("Selecione um cliente por favor");
                return;
            }

            int clienteId = Convert.ToInt32(cmbClientes.SelectedValue);

            if (clienteId == 0) {
                MessageBox.Show("Selecione um cliente para cadastar a dívida");
                return;
            }


            if (!decimal.TryParse(txtValor.Text, out decimal valor)) {
                MessageBox.Show("Digite um valor válido para a dívida");
                return;
            }

            Divida novaDivida = new Divida {
                ClienteId = clienteId,
                Valor = valor
            };

            bool cadastrou = servicoDivida.Criar(novaDivida, out var erros);

            if (cadastrou) {
                MessageBox.Show("Dívida Cadastrada com sucesso!");
                txtValor.Clear();
                CarregarDividas();
            } else {
                string mensagens = string.Join("\n", erros.Select(e => e.ErrorMessage));

                MessageBox.Show(mensagens);
            }
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e) {
            paginaAtual = 1;
            CarregarDividas();
        }

        private void btnQuitar_Click(object sender, EventArgs e) {
            if (dgvDividas.SelectedRows.Count == 0) {
                MessageBox.Show("Selecione uma dívida para quitar.");
                return;
            }

            int dividaId = Convert.ToInt32(dgvDividas.SelectedRows[0].Cells["colId"].Value);


            DialogResult resposta = MessageBox.Show(
                    "Deseja Realmente quitar essa dívida?",
                    "Confirmar pagamento",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
            );

            if (resposta == DialogResult.No) {
                return;
            }

            bool quitou = servicoDivida.Quitar(dividaId);


            if (quitou) {
                MessageBox.Show("dívida quitada com sucesso");
                CarregarDividas();
            } else {
                MessageBox.Show("Não foi possível quitar a dívida, ela já está paga");
            }
        }

        private void TelaDividas_Shown(object sender, EventArgs e) {
            dgvDividas.ClearSelection();
        }

        private void btnProximo_Click(object sender, EventArgs e) {
            if (cmbClientes.SelectedValue == null) {
                return;
            }

            int clienteId = Convert.ToInt32(cmbClientes.SelectedValue);

            int totalDePaginas = (int)Math.Ceiling(servicoDivida.ContarDividas(clienteId) / (double)registrosPorPagina);

            if (paginaAtual < totalDePaginas) {
                paginaAtual++;
                CarregarDividas();
            }
        }

        private void lblAnterior_Click(object sender, EventArgs e) {
            if (paginaAtual > 1) {
                paginaAtual--;
                CarregarDividas();
            }
        }

        private void txtPesquisarCliente_TextChanged(object sender, EventArgs e) {
            CarregarClientes(txtPesquisarCliente.Text);
        }

        private void lblClientes_Click(object sender, EventArgs e) {

        }

        private void btnVoltar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
