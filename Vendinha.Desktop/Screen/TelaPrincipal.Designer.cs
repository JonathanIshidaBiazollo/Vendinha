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
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(189, 150);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(94, 29);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnDividas
            // 
            btnDividas.Location = new Point(402, 157);
            btnDividas.Name = "btnDividas";
            btnDividas.Size = new Size(94, 29);
            btnDividas.TabIndex = 1;
            btnDividas.Text = "Dívidas";
            btnDividas.UseVisualStyleBackColor = true;
            btnDividas.Click += btnDividas_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}