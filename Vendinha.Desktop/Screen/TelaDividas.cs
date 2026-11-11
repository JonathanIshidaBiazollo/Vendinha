using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Vendinha.Services;

namespace Vendinha.Desktop.Screen {
    public partial class TelaDividas : Form {
        private ClienteService servicoClientes;
        public TelaDividas() {
            InitializeComponent();

            servicoClientes = new ClienteService();

            CarregarClientes();
        }

        private void CarregarClientes() {
            var clientes = servicoClientes.Consultar();

            cmbClientes.DataSource = clientes;
        }
    }
}
