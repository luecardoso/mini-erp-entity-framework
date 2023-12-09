namespace MiniERP
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Cliente_Click(object sender, EventArgs e)
        {
            Form_Cliente cliente = new Form_Cliente();
            cliente.Show();
            this.Hide();
        }

        private void fornecedoresToolStripMenuItem_Fornecedor_Click(object sender, EventArgs e)
        {
            Form_Fornecedor fornecedor = new Form_Fornecedor();
            fornecedor.Show();
            this.Hide();
        }

        private void produtosToolStripMenuItem_Produto_Click(object sender, EventArgs e)
        {
            Form_Produto produtos = new Form_Produto();
            produtos.Show();
            this.Hide();
        }
    }
}
