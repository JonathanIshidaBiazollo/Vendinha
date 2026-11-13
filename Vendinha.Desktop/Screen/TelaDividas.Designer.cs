namespace Vendinha.Desktop.Screen {
    partial class TelaDividas {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btnCadastrar = new Button();
            btnQuitar = new Button();
            dgvDividas = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colValor = new DataGridViewTextBoxColumn();
            colSituacao = new DataGridViewTextBoxColumn();
            colDataCriacao = new DataGridViewTextBoxColumn();
            colDataPagamento = new DataGridViewTextBoxColumn();
            cmbClientes = new ComboBox();
            lblClientes = new Label();
            lblValor = new Label();
            txtValor = new TextBox();
            lblAnterior = new Button();
            btnProximo = new Button();
            lblPagina = new Label();
            txtPesquisarCliente = new TextBox();
            lblPesquisar = new Label();
            lblAviso = new Label();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDividas).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Image = Properties.Resources.loan;
            btnCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.Location = new Point(31, 323);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(115, 63);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar\r\nDívida";
            btnCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Image = Properties.Resources.payment;
            btnQuitar.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuitar.Location = new Point(184, 323);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(115, 63);
            btnQuitar.TabIndex = 1;
            btnQuitar.Text = "Quitar\r\nDívida";
            btnQuitar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // dgvDividas
            // 
            dgvDividas.AllowUserToAddRows = false;
            dgvDividas.AllowUserToDeleteRows = false;
            dgvDividas.AllowUserToResizeColumns = false;
            dgvDividas.AllowUserToResizeRows = false;
            dgvDividas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDividas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDividas.Columns.AddRange(new DataGridViewColumn[] { colId, colCliente, colValor, colSituacao, colDataCriacao, colDataPagamento });
            dgvDividas.Location = new Point(407, 64);
            dgvDividas.MultiSelect = false;
            dgvDividas.Name = "dgvDividas";
            dgvDividas.ReadOnly = true;
            dgvDividas.RowHeadersWidth = 51;
            dgvDividas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDividas.Size = new Size(678, 350);
            dgvDividas.TabIndex = 2;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colCliente
            // 
            colCliente.HeaderText = "Cliente";
            colCliente.MinimumWidth = 6;
            colCliente.Name = "colCliente";
            colCliente.ReadOnly = true;
            // 
            // colValor
            // 
            colValor.HeaderText = "Valor";
            colValor.MinimumWidth = 6;
            colValor.Name = "colValor";
            colValor.ReadOnly = true;
            // 
            // colSituacao
            // 
            colSituacao.HeaderText = "Situação";
            colSituacao.MinimumWidth = 6;
            colSituacao.Name = "colSituacao";
            colSituacao.ReadOnly = true;
            // 
            // colDataCriacao
            // 
            colDataCriacao.HeaderText = "Data de criação";
            colDataCriacao.MinimumWidth = 6;
            colDataCriacao.Name = "colDataCriacao";
            colDataCriacao.ReadOnly = true;
            // 
            // colDataPagamento
            // 
            colDataPagamento.HeaderText = "Data de pagamento";
            colDataPagamento.MinimumWidth = 6;
            colDataPagamento.Name = "colDataPagamento";
            colDataPagamento.ReadOnly = true;
            // 
            // cmbClientes
            // 
            cmbClientes.DisplayMember = "Nome";
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(27, 180);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(226, 28);
            cmbClientes.TabIndex = 3;
            cmbClientes.ValueMember = "Id";
            cmbClientes.SelectedIndexChanged += cmbClientes_SelectedIndexChanged;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Location = new Point(27, 127);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(353, 40);
            lblClientes.TabIndex = 4;
            lblClientes.Text = "Selecione o cliente que deseja cadastrar uma dívida\r\nou que deseja ver suas dívidas em específico\r\n";
            lblClientes.Click += lblClientes_Click;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(27, 232);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(43, 20);
            lblValor.TabIndex = 5;
            lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(30, 269);
            txtValor.Name = "txtValor";
            txtValor.PlaceholderText = "Ex: 50,00 ou 50.00 ou 50";
            txtValor.Size = new Size(223, 27);
            txtValor.TabIndex = 6;
            // 
            // lblAnterior
            // 
            lblAnterior.Image = Properties.Resources.arrow;
            lblAnterior.Location = new Point(582, 429);
            lblAnterior.Name = "lblAnterior";
            lblAnterior.Size = new Size(115, 63);
            lblAnterior.TabIndex = 7;
            lblAnterior.TextImageRelation = TextImageRelation.ImageBeforeText;
            lblAnterior.UseVisualStyleBackColor = true;
            lblAnterior.Click += lblAnterior_Click;
            // 
            // btnProximo
            // 
            btnProximo.Image = Properties.Resources.next1;
            btnProximo.Location = new Point(807, 428);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(115, 63);
            btnProximo.TabIndex = 8;
            btnProximo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // lblPagina
            // 
            lblPagina.AutoSize = true;
            lblPagina.Location = new Point(703, 449);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(98, 20);
            lblPagina.TabIndex = 9;
            lblPagina.Text = "Página 1 de 1";
            // 
            // txtPesquisarCliente
            // 
            txtPesquisarCliente.Location = new Point(27, 64);
            txtPesquisarCliente.Name = "txtPesquisarCliente";
            txtPesquisarCliente.PlaceholderText = "Pesquisar cliente...";
            txtPesquisarCliente.Size = new Size(226, 27);
            txtPesquisarCliente.TabIndex = 10;
            txtPesquisarCliente.TextChanged += txtPesquisarCliente_TextChanged;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(27, 9);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(260, 40);
            lblPesquisar.TabIndex = 11;
            lblPesquisar.Text = "Filtre os nomes do combo box abaixo\r\nFacilitando sua busca\r\n";
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.Location = new Point(653, 18);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(206, 40);
            lblAviso.TabIndex = 12;
            lblAviso.Text = "Escolha um cliente na tabela\r\n abaixo para quitar sua dívida";
            // 
            // btnVoltar
            // 
            btnVoltar.Image = Properties.Resources.back;
            btnVoltar.Location = new Point(31, 449);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(115, 63);
            btnVoltar.TabIndex = 13;
            btnVoltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // TelaDividas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1097, 534);
            Controls.Add(btnVoltar);
            Controls.Add(lblAviso);
            Controls.Add(lblPesquisar);
            Controls.Add(txtPesquisarCliente);
            Controls.Add(lblPagina);
            Controls.Add(btnProximo);
            Controls.Add(lblAnterior);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Controls.Add(lblClientes);
            Controls.Add(cmbClientes);
            Controls.Add(dgvDividas);
            Controls.Add(btnQuitar);
            Controls.Add(btnCadastrar);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlLight;
            Name = "TelaDividas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaDividas";
            Shown += TelaDividas_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvDividas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Button btnQuitar;
        private DataGridView dgvDividas;
        private ComboBox cmbClientes;
        private Label lblClientes;
        private Label lblValor;
        private TextBox txtValor;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colValor;
        private DataGridViewTextBoxColumn colSituacao;
        private DataGridViewTextBoxColumn colDataCriacao;
        private DataGridViewTextBoxColumn colDataPagamento;
        private Button lblAnterior;
        private Button btnProximo;
        private Label lblPagina;
        private TextBox txtPesquisarCliente;
        private Label lblPesquisar;
        private Label lblAviso;
        private Button btnVoltar;
    }
}