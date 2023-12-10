﻿namespace MiniERP
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
            label5 = new Label();
            button_BuscarProduto = new Button();
            textBox_BuscarProduto = new TextBox();
            button_BuscarCliente = new Button();
            button_SelecionarCliente = new Button();
            textBox_BuscarCliente = new TextBox();
            dataGridView_Clientes = new DataGridView();
            label4 = new Label();
            textBox_Quantidade = new TextBox();
            label3 = new Label();
            button_AdicionarItem = new Button();
            dataGridView_Produtos = new DataGridView();
            textBox_DataHora = new TextBox();
            label2 = new Label();
            button_RealizarVenda = new Button();
            label1 = new Label();
            dataGridView_ItemPedido = new DataGridView();
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem_Cliente = new ToolStripMenuItem();
            visualizarComprasToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem_Fornecedor = new ToolStripMenuItem();
            produtosToolStripMenuItem_Produto = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            informacoesToolStripMenuItem_Informacoes = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Produtos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ItemPedido).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button_BuscarProduto);
            panel1.Controls.Add(textBox_BuscarProduto);
            panel1.Controls.Add(button_BuscarCliente);
            panel1.Controls.Add(button_SelecionarCliente);
            panel1.Controls.Add(textBox_BuscarCliente);
            panel1.Controls.Add(dataGridView_Clientes);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox_Quantidade);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button_AdicionarItem);
            panel1.Controls.Add(dataGridView_Produtos);
            panel1.Controls.Add(textBox_DataHora);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button_RealizarVenda);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView_ItemPedido);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1219, 784);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 312);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 18;
            label5.Text = "Produto";
            // 
            // button_BuscarProduto
            // 
            button_BuscarProduto.Location = new Point(509, 312);
            button_BuscarProduto.Name = "button_BuscarProduto";
            button_BuscarProduto.Size = new Size(75, 23);
            button_BuscarProduto.TabIndex = 17;
            button_BuscarProduto.Text = "Buscar";
            button_BuscarProduto.UseVisualStyleBackColor = true;
            button_BuscarProduto.Click += button_BuscarProduto_Click;
            // 
            // textBox_BuscarProduto
            // 
            textBox_BuscarProduto.Location = new Point(124, 312);
            textBox_BuscarProduto.Name = "textBox_BuscarProduto";
            textBox_BuscarProduto.Size = new Size(364, 23);
            textBox_BuscarProduto.TabIndex = 16;
            // 
            // button_BuscarCliente
            // 
            button_BuscarCliente.Location = new Point(507, 51);
            button_BuscarCliente.Name = "button_BuscarCliente";
            button_BuscarCliente.Size = new Size(75, 23);
            button_BuscarCliente.TabIndex = 15;
            button_BuscarCliente.Text = "Buscar";
            button_BuscarCliente.UseVisualStyleBackColor = true;
            button_BuscarCliente.Click += button_BuscarCliente_Click;
            // 
            // button_SelecionarCliente
            // 
            button_SelecionarCliente.Location = new Point(507, 234);
            button_SelecionarCliente.Name = "button_SelecionarCliente";
            button_SelecionarCliente.Size = new Size(75, 23);
            button_SelecionarCliente.TabIndex = 14;
            button_SelecionarCliente.Text = "Selecionar";
            button_SelecionarCliente.UseVisualStyleBackColor = true;
            // 
            // textBox_BuscarCliente
            // 
            textBox_BuscarCliente.Location = new Point(124, 50);
            textBox_BuscarCliente.Name = "textBox_BuscarCliente";
            textBox_BuscarCliente.Size = new Size(375, 23);
            textBox_BuscarCliente.TabIndex = 13;
            // 
            // dataGridView_Clientes
            // 
            dataGridView_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Clientes.Location = new Point(25, 92);
            dataGridView_Clientes.Name = "dataGridView_Clientes";
            dataGridView_Clientes.RowTemplate.Height = 25;
            dataGridView_Clientes.Size = new Size(559, 126);
            dataGridView_Clientes.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(660, 24);
            label4.Name = "label4";
            label4.Size = new Size(186, 32);
            label4.TabIndex = 11;
            label4.Text = "Lista de Compra";
            // 
            // textBox_Quantidade
            // 
            textBox_Quantidade.Location = new Point(106, 690);
            textBox_Quantidade.Name = "textBox_Quantidade";
            textBox_Quantidade.Size = new Size(100, 23);
            textBox_Quantidade.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 693);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 9;
            label3.Text = "Quantidade: ";
            // 
            // button_AdicionarItem
            // 
            button_AdicionarItem.Location = new Point(454, 690);
            button_AdicionarItem.Name = "button_AdicionarItem";
            button_AdicionarItem.Size = new Size(130, 23);
            button_AdicionarItem.TabIndex = 8;
            button_AdicionarItem.Text = "Adicionar a Lista";
            button_AdicionarItem.UseVisualStyleBackColor = true;
            button_AdicionarItem.Click += button_AdicionarItem_Click;
            // 
            // dataGridView_Produtos
            // 
            dataGridView_Produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Produtos.Location = new Point(25, 355);
            dataGridView_Produtos.Name = "dataGridView_Produtos";
            dataGridView_Produtos.RowTemplate.Height = 25;
            dataGridView_Produtos.Size = new Size(559, 318);
            dataGridView_Produtos.TabIndex = 7;
            // 
            // textBox_DataHora
            // 
            textBox_DataHora.Enabled = false;
            textBox_DataHora.Location = new Point(1043, 27);
            textBox_DataHora.Name = "textBox_DataHora";
            textBox_DataHora.Size = new Size(164, 23);
            textBox_DataHora.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(987, 30);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 5;
            label2.Text = "Data: ";
            // 
            // button_RealizarVenda
            // 
            button_RealizarVenda.Location = new Point(1086, 732);
            button_RealizarVenda.Name = "button_RealizarVenda";
            button_RealizarVenda.Size = new Size(121, 31);
            button_RealizarVenda.TabIndex = 4;
            button_RealizarVenda.Text = "Realizar Venda";
            button_RealizarVenda.UseVisualStyleBackColor = true;
            button_RealizarVenda.Click += button_RealizarVenda_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 50);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Cliente";
            // 
            // dataGridView_ItemPedido
            // 
            dataGridView_ItemPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_ItemPedido.Location = new Point(660, 68);
            dataGridView_ItemPedido.Name = "dataGridView_ItemPedido";
            dataGridView_ItemPedido.RowTemplate.Height = 25;
            dataGridView_ItemPedido.Size = new Size(547, 645);
            dataGridView_ItemPedido.TabIndex = 1;
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
            clientesToolStripMenuItem_Cliente.DropDownItems.AddRange(new ToolStripItem[] { visualizarComprasToolStripMenuItem });
            clientesToolStripMenuItem_Cliente.Name = "clientesToolStripMenuItem_Cliente";
            clientesToolStripMenuItem_Cliente.Size = new Size(145, 22);
            clientesToolStripMenuItem_Cliente.Text = "Clientes";
            clientesToolStripMenuItem_Cliente.Click += clientesToolStripMenuItem_Cliente_Click;
            // 
            // visualizarComprasToolStripMenuItem
            // 
            visualizarComprasToolStripMenuItem.Name = "visualizarComprasToolStripMenuItem";
            visualizarComprasToolStripMenuItem.Size = new Size(174, 22);
            visualizarComprasToolStripMenuItem.Text = "Visualizar Compras";
            // 
            // fornecedoresToolStripMenuItem_Fornecedor
            // 
            fornecedoresToolStripMenuItem_Fornecedor.Name = "fornecedoresToolStripMenuItem_Fornecedor";
            fornecedoresToolStripMenuItem_Fornecedor.Size = new Size(145, 22);
            fornecedoresToolStripMenuItem_Fornecedor.Text = "Fornecedores";
            fornecedoresToolStripMenuItem_Fornecedor.Click += fornecedoresToolStripMenuItem_Fornecedor_Click;
            // 
            // produtosToolStripMenuItem_Produto
            // 
            produtosToolStripMenuItem_Produto.DropDownItems.AddRange(new ToolStripItem[] { categoriasToolStripMenuItem });
            produtosToolStripMenuItem_Produto.Name = "produtosToolStripMenuItem_Produto";
            produtosToolStripMenuItem_Produto.Size = new Size(145, 22);
            produtosToolStripMenuItem_Produto.Text = "Produtos";
            produtosToolStripMenuItem_Produto.Click += produtosToolStripMenuItem_Produto_Click;
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(130, 22);
            categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informacoesToolStripMenuItem_Informacoes });
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // informacoesToolStripMenuItem_Informacoes
            // 
            informacoesToolStripMenuItem_Informacoes.Name = "informacoesToolStripMenuItem_Informacoes";
            informacoesToolStripMenuItem_Informacoes.Size = new Size(140, 22);
            informacoesToolStripMenuItem_Informacoes.Text = "Informações";
            // 
            // Form_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 784);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Form_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caixa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Produtos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ItemPedido).EndInit();
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
        private DataGridView dataGridView_ItemPedido;
        private Label label1;
        private Button button_RealizarVenda;
        private TextBox textBox_DataHora;
        private Label label2;
        private ToolStripMenuItem visualizarComprasToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem informacoesToolStripMenuItem_Informacoes;
        private Button button_AdicionarItem;
        private DataGridView dataGridView_Produtos;
        private TextBox textBox_Quantidade;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView_Clientes;
        private Button button_BuscarCliente;
        private Button button_SelecionarCliente;
        private TextBox textBox_BuscarCliente;
        private TextBox textBox_BuscarProduto;
        private Label label5;
        private Button button_BuscarProduto;
    }
}
