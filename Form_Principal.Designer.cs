namespace MiniERP
{
    partial class Form_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem_Cliente = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem_Fornecedor = new ToolStripMenuItem();
            produtosToolStripMenuItem_Produto = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1219, 784);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1219, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem_Cliente, fornecedoresToolStripMenuItem_Fornecedor, produtosToolStripMenuItem_Produto });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem_Cliente
            // 
            clientesToolStripMenuItem_Cliente.Name = "clientesToolStripMenuItem_Cliente";
            clientesToolStripMenuItem_Cliente.Size = new Size(180, 22);
            clientesToolStripMenuItem_Cliente.Text = "Clientes";
            clientesToolStripMenuItem_Cliente.Click += clientesToolStripMenuItem_Cliente_Click;
            // 
            // fornecedoresToolStripMenuItem_Fornecedor
            // 
            fornecedoresToolStripMenuItem_Fornecedor.Name = "fornecedoresToolStripMenuItem_Fornecedor";
            fornecedoresToolStripMenuItem_Fornecedor.Size = new Size(180, 22);
            fornecedoresToolStripMenuItem_Fornecedor.Text = "Fornecedores";
            fornecedoresToolStripMenuItem_Fornecedor.Click += fornecedoresToolStripMenuItem_Fornecedor_Click;
            // 
            // produtosToolStripMenuItem_Produto
            // 
            produtosToolStripMenuItem_Produto.Name = "produtosToolStripMenuItem_Produto";
            produtosToolStripMenuItem_Produto.Size = new Size(180, 22);
            produtosToolStripMenuItem_Produto.Text = "Produtos";
            produtosToolStripMenuItem_Produto.Click += produtosToolStripMenuItem_Produto_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // Form_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 784);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Form_Principal";
            Text = "Caixa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem_Cliente;
        private ToolStripMenuItem fornecedoresToolStripMenuItem_Fornecedor;
        private ToolStripMenuItem produtosToolStripMenuItem_Produto;
        private ToolStripMenuItem sobreToolStripMenuItem;
    }
}
