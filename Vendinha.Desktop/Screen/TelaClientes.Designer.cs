namespace Vendinha.Desktop {
    partial class TelaClientes {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblNome = new Label();
            txtNome = new TextBox();
            lblCpf = new Label();
            lblDataNascimento = new Label();
            dtpDataNascimento = new DateTimePicker();
            lblEmail = new Label();
            txtEmail = new TextBox();
            mskCpf = new MaskedTextBox();
            btnCadastrar = new Button();
            dgvClientes = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            ColCpf = new DataGridViewTextBoxColumn();
            colDataNascimento = new DataGridViewTextBoxColumn();
            colIdade = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colTotalPago = new DataGridViewTextBoxColumn();
            colDevido = new DataGridViewTextBoxColumn();
            txtPesquisar = new TextBox();
            lblPesquisar = new Label();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnCancelarEdicao = new Button();
            btnAnterior = new Button();
            btnProximo = new Button();
            lblPágina = new Label();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(21, 23);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(57, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome: ";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(133, 23);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome e Sobrenome";
            txtNome.Size = new Size(152, 27);
            txtNome.TabIndex = 1;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(21, 82);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(49, 20);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "C.P.F.: ";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(12, 138);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(95, 40);
            lblDataNascimento.TabIndex = 4;
            lblDataNascimento.Text = "Data de\r\nNascimento: ";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(133, 151);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(151, 27);
            dtpDataNascimento.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 202);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email: ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(133, 202);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "ex: nome@email.com";
            txtEmail.Size = new Size(152, 27);
            txtEmail.TabIndex = 7;
            // 
            // mskCpf
            // 
            mskCpf.Location = new Point(134, 75);
            mskCpf.Mask = "000.000.000-00";
            mskCpf.Name = "mskCpf";
            mskCpf.Size = new Size(151, 27);
            mskCpf.TabIndex = 8;
            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Image = Properties.Resources.add_user__2_;
            btnCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.Location = new Point(21, 262);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(115, 63);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { colId, colNome, ColCpf, colDataNascimento, colIdade, colEmail, colTotalPago, colDevido });
            dgvClientes.Location = new Point(314, 65);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(1125, 343);
            dgvClientes.TabIndex = 10;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colNome
            // 
            colNome.HeaderText = "Nome";
            colNome.MinimumWidth = 6;
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            // 
            // ColCpf
            // 
            ColCpf.HeaderText = "C.P.F.";
            ColCpf.MinimumWidth = 6;
            ColCpf.Name = "ColCpf";
            ColCpf.ReadOnly = true;
            // 
            // colDataNascimento
            // 
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            colDataNascimento.DefaultCellStyle = dataGridViewCellStyle1;
            colDataNascimento.HeaderText = "Data de Nascimento";
            colDataNascimento.MinimumWidth = 6;
            colDataNascimento.Name = "colDataNascimento";
            colDataNascimento.ReadOnly = true;
            // 
            // colIdade
            // 
            colIdade.HeaderText = "Idade";
            colIdade.MinimumWidth = 6;
            colIdade.Name = "colIdade";
            colIdade.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colTotalPago
            // 
            colTotalPago.HeaderText = "Total Pago";
            colTotalPago.MinimumWidth = 6;
            colTotalPago.Name = "colTotalPago";
            colTotalPago.ReadOnly = true;
            // 
            // colDevido
            // 
            colDevido.HeaderText = "Total Devido";
            colDevido.MinimumWidth = 6;
            colDevido.Name = "colDevido";
            colDevido.ReadOnly = true;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(718, 23);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Ex: Maria, maria";
            txtPesquisar.Size = new Size(568, 27);
            txtPesquisar.TabIndex = 11;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(353, 26);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(359, 20);
            lblPesquisar.TabIndex = 12;
            lblPesquisar.Text = "Digite aqui no nome do cliente que deseja pesquisar";
            // 
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.recycle_bin;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(159, 345);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(115, 63);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Image = Properties.Resources.sync;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(21, 345);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(115, 63);
            btnEditar.TabIndex = 0;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelarEdicao
            // 
            btnCancelarEdicao.Image = Properties.Resources.prohibition;
            btnCancelarEdicao.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarEdicao.Location = new Point(159, 262);
            btnCancelarEdicao.Name = "btnCancelarEdicao";
            btnCancelarEdicao.Size = new Size(115, 63);
            btnCancelarEdicao.TabIndex = 14;
            btnCancelarEdicao.Text = "Cancelar Edição";
            btnCancelarEdicao.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelarEdicao.UseVisualStyleBackColor = true;
            btnCancelarEdicao.Visible = false;
            btnCancelarEdicao.Click += btnCancelarEdicao_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Image = Properties.Resources.arrow;
            btnAnterior.Location = new Point(725, 422);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(115, 63);
            btnAnterior.TabIndex = 15;
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnProximo
            // 
            btnProximo.Image = Properties.Resources.next;
            btnProximo.Location = new Point(950, 425);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(115, 63);
            btnProximo.TabIndex = 16;
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // lblPágina
            // 
            lblPágina.AutoSize = true;
            lblPágina.Location = new Point(846, 443);
            lblPágina.Name = "lblPágina";
            lblPágina.Size = new Size(98, 20);
            lblPágina.TabIndex = 17;
            lblPágina.Text = "Página 1 de 1";
            // 
            // btnVoltar
            // 
            btnVoltar.Image = Properties.Resources.back;
            btnVoltar.Location = new Point(21, 509);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(115, 63);
            btnVoltar.TabIndex = 18;
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // TelaClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1451, 586);
            Controls.Add(btnVoltar);
            Controls.Add(lblPágina);
            Controls.Add(btnProximo);
            Controls.Add(btnAnterior);
            Controls.Add(btnCancelarEdicao);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(lblPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(dgvClientes);
            Controls.Add(btnCadastrar);
            Controls.Add(mskCpf);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(dtpDataNascimento);
            Controls.Add(lblDataNascimento);
            Controls.Add(lblCpf);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TelaClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendinha - Cadastro de clientes";
            Load += Form1_Load;
            Shown += TelaClientes_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblCpf;
        private Label lblDataNascimento;
        private DateTimePicker dtpDataNascimento;
        private Label lblEmail;
        private TextBox txtEmail;
        private MaskedTextBox mskCpf;
        private Button btnCadastrar;
        private DataGridView dgvClientes;
        private TextBox txtPesquisar;
        private Label lblPesquisar;
        private Button btnExcluir;
        private Button btnEditar;
        private Button btnCancelarEdicao;
        private Button btnAnterior;
        private Button btnProximo;
        private Label lblPágina;
        private Button btnVoltar;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn ColCpf;
        private DataGridViewTextBoxColumn colDataNascimento;
        private DataGridViewTextBoxColumn colIdade;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colTotalPago;
        private DataGridViewTextBoxColumn colDevido;
    }
}
