namespace Vendinha.Desktop.Screen {
    partial class TelaPrincipal {
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
            btnClientes = new Button();
            btnDividas = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Image = Properties.Resources.customer_engagement;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(197, 140);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(103, 63);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnDividas
            // 
            btnDividas.Image = Properties.Resources.debt;
            btnDividas.ImageAlign = ContentAlignment.MiddleLeft;
            btnDividas.Location = new Point(356, 140);
            btnDividas.Name = "btnDividas";
            btnDividas.Size = new Size(99, 63);
            btnDividas.TabIndex = 1;
            btnDividas.Text = "Dívidas";
            btnDividas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDividas.UseVisualStyleBackColor = true;
            btnDividas.Click += btnDividas_Click;
            // 
            // btnSair
            // 
            btnSair.Image = Properties.Resources.delete;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(512, 140);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 63);
            btnSair.TabIndex = 2;
            btnSair.Text = " Sair";
            btnSair.TextAlign = ContentAlignment.MiddleRight;
            btnSair.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 370);
            Controls.Add(btnSair);
            Controls.Add(btnDividas);
            Controls.Add(btnClientes);
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnDividas;
        private Button btnSair;
    }
}