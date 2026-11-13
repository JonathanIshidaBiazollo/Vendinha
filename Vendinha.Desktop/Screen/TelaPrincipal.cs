using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vendinha.Desktop.Screen {
    public partial class TelaPrincipal : Form {
        public TelaPrincipal() {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e) {
            TelaClientes tela = new TelaClientes();
            tela.ShowDialog();
        }

        private void btnDividas_Click(object sender, EventArgs e) {
            TelaDividas tela = new TelaDividas();
            tela.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
