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
            lblNome = new Label();
            txtNome = new TextBox();
            lblCpf = new Label();
            lblDataNascimento = new Label();
            dtpDataNascimento = new DateTimePicker();
            lblEmail = new Label();
            txtEmail = new TextBox();
            mskCpf = new MaskedTextBox();
            btnCadastrar = new Button();
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
            txtNome.Size = new Size(125, 27);
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
            txtEmail.Size = new Size(125, 27);
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
            btnCadastrar.Location = new Point(160, 452);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 29);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // TelaClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 603);
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
    }
}
