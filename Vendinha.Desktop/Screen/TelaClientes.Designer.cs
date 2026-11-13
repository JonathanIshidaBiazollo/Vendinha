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
            colTotalDevido = new DataGridViewTextBoxColumn();
            txtPesquisar = new TextBox();
            lblPesquisar = new Label();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnCancelarEdicao = new Button();
            btnAnterior = new Button();
            btnProximo = new Button();
            lblPágina = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(159, 31);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(57, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome: ";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(159, 65);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome e Sobrenome";
            txtNome.Size = new Size(152, 27);
            txtNome.TabIndex = 1;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(159, 127);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(49, 20);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "C.P.F.: ";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(159, 233);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(152, 20);
            lblDataNascimento.TabIndex = 4;
            lblDataNascimento.Text = "Data de Nascimento: ";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(159, 281);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(125, 27);
            dtpDataNascimento.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(155, 336);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email: ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(159, 381);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "ex: nome@email.com";
            txtEmail.Size = new Size(169, 27);
            txtEmail.TabIndex = 7;
            // 
            // mskCpf
            // 
            mskCpf.Location = new Point(159, 172);
            mskCpf.Mask = "000.000.000-00";
            mskCpf.Name = "mskCpf";
            mskCpf.Size = new Size(125, 27);
            mskCpf.TabIndex = 8;
            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(103, 455);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(151, 29);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { colId, colNome, ColCpf, colDataNascimento, colIdade, colEmail, colTotalDevido });
            dgvClientes.Location = new Point(350, 65);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(936, 343);
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
            // colTotalDevido
            // 
            colTotalDevido.HeaderText = "Total Devido";
            colTotalDevido.MinimumWidth = 6;
            colTotalDevido.Name = "colTotalDevido";
            colTotalDevido.ReadOnly = true;
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
            btnExcluir.Location = new Point(1192, 428);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(103, 502);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(151, 29);
            btnEditar.TabIndex = 0;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelarEdicao
            // 
            btnCancelarEdicao.Location = new Point(260, 455);
            btnCancelarEdicao.Name = "btnCancelarEdicao";
            btnCancelarEdicao.Size = new Size(143, 29);
            btnCancelarEdicao.TabIndex = 14;
            btnCancelarEdicao.Text = "Cancelar Edição";
            btnCancelarEdicao.UseVisualStyleBackColor = true;
            btnCancelarEdicao.Visible = false;
            btnCancelarEdicao.Click += btnCancelarEdicao_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(543, 429);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(94, 29);
            btnAnterior.TabIndex = 15;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnProximo
            // 
            btnProximo.Location = new Point(930, 428);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(94, 29);
            btnProximo.TabIndex = 16;
            btnProximo.Text = "Próximo";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // lblPágina
            // 
            lblPágina.AutoSize = true;
            lblPágina.Location = new Point(755, 428);
            lblPágina.Name = "lblPágina";
            lblPágina.Size = new Size(92, 20);
            lblPágina.TabIndex = 17;
            lblPágina.Text = "Página Atual";
            // 
            // TelaClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1346, 603);
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
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn ColCpf;
        private DataGridViewTextBoxColumn colDataNascimento;
        private DataGridViewTextBoxColumn colIdade;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colTotalDevido;
    }
}
