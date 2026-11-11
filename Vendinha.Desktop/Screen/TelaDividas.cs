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

            cmbClientes.DataSource = clientes;
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            if(cmbClientes.SelectedValue == null) {
                MessageBox.Show("Selecione um cliente por favor");
                return;
            }

            int clienteId = Convert.ToInt32(cmbClientes.SelectedValue);

            if(!decimal.TryParse(txtValor.Text, out decimal valor)){
                MessageBox.Show("Digite um valor válido para a dívida\n" +
                                "Ex: 10,50 ou 10.50");
                return;
            }

            MessageBox.Show($"{clienteId}");
        }
    }
}
