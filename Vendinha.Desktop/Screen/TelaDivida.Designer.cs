namespace Vendinha.Desktop.Screen {
    partial class TelaDivida {
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
            cmbClientes = new ComboBox();
            txtValor = new TextBox();
            lblValor = new Label();
            btnCadastrar = new Button();
            dataGridView1 = new DataGridView();
            lblClientes = new Label();
            btnQuitar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbClientes
            // 
            cmbClientes.DisplayMember = "Nome";
            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(118, 85);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(151, 28);
            cmbClientes.TabIndex = 0;
            cmbClientes.ValueMember = "Id";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(389, 82);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(125, 27);
            txtValor.TabIndex = 1;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(310, 81);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(43, 20);
            lblValor.TabIndex = 2;
            lblValor.Text = "Valor";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(135, 187);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 29);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(559, 61);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 4;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Location = new Point(27, 85);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(61, 20);
            lblClientes.TabIndex = 5;
            lblClientes.Text = "Clientes";
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(322, 187);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(133, 29);
            btnQuitar.TabIndex = 6;
            btnQuitar.Text = "Quitar Dívida";
            btnQuitar.UseVisualStyleBackColor = true;
            // 
            // TelaDivida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 678);
            Controls.Add(btnQuitar);
            Controls.Add(lblClientes);
            Controls.Add(dataGridView1);
            Controls.Add(btnCadastrar);
            Controls.Add(lblValor);
            Controls.Add(txtValor);
            Controls.Add(cmbClientes);
            Name = "TelaDivida";
            Text = "TelaDivida";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbClientes;
        private TextBox txtValor;
        private Label lblValor;
        private Button btnCadastrar;
        private DataGridView dataGridView1;
        private Label lblClientes;
        private Button btnQuitar;
    }
}