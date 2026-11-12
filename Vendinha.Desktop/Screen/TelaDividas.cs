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
        public TelaDividas() {
            InitializeComponent();

            servicoClientes = new ClienteService();
            servicoDivida = new DividaService();

            CarregarClientes();
        }

        private void CarregarClientes() {
            var clientes = servicoClientes.Consultar();

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

            var dividas = servicoDivida.Consultar(clienteId);

            foreach (var divida in dividas) {
                dgvDividas.Rows.Add(
                    divida.Id,
                    divida.Valor,
                    divida.Paga ? "Paga" : "Não Paga",
                    divida.DataCriacao,
                    divida.DataPagamento
                );
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            if (cmbClientes.SelectedValue == null) {
                MessageBox.Show("Selecione um cliente por favor");
                return;
            }

            int clienteId = Convert.ToInt32(cmbClientes.SelectedValue);

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
            } else {
                string mensagens = string.Join("\n", erros.Select(e => e.ErrorMessage));

                MessageBox.Show(mensagens);
            }
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e) {
            CarregarDividas();
        }
    }
}
