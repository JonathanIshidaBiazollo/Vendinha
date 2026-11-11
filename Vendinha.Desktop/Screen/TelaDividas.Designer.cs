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
            cmbClientes = new ComboBox();
            lblClientes = new Label();
            lblValor = new Label();
            txtValor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDividas).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(34, 229);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(115, 63);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(210, 229);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(115, 63);
            btnQuitar.TabIndex = 1;
            btnQuitar.Text = "Quitar\r\nDívida";
            btnQuitar.UseVisualStyleBackColor = true;
            // 
            // dgvDividas
            // 
            dgvDividas.AllowUserToAddRows = false;
            dgvDividas.AllowUserToDeleteRows = false;
            dgvDividas.AllowUserToResizeColumns = false;
            dgvDividas.AllowUserToResizeRows = false;
            dgvDividas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDividas.Location = new Point(470, 46);
            dgvDividas.MultiSelect = false;
            dgvDividas.Name = "dgvDividas";
            dgvDividas.ReadOnly = true;
            dgvDividas.RowHeadersWidth = 51;
            dgvDividas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDividas.Size = new Size(300, 188);
            dgvDividas.TabIndex = 2;
            // 
            // cmbClientes
            // 
            cmbClientes.DisplayMember = "Nome";
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(21, 59);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(151, 28);
            cmbClientes.TabIndex = 3;
            cmbClientes.ValueMember = "Id";
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Location = new Point(21, 21);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(61, 20);
            lblClientes.TabIndex = 4;
            lblClientes.Text = "Clientes";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(21, 120);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(43, 20);
            lblValor.TabIndex = 5;
            lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(24, 157);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(125, 27);
            txtValor.TabIndex = 6;
            // 
            // TelaDividas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Controls.Add(lblClientes);
            Controls.Add(cmbClientes);
            Controls.Add(dgvDividas);
            Controls.Add(btnQuitar);
            Controls.Add(btnCadastrar);
            Name = "TelaDividas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaDividas";
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
    }
}