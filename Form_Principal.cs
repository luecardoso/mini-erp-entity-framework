using System.Data;

namespace MiniERP
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
            CarregarClientes();
            CarregarProdutos();
            textBox_DataHora.Text = DateTime.Now.ToString();
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

        private void CarregarClientes()
        {
            using (var contexto = new MiniErpContext())
            {
                //var clientes = contexto.Clientes.ToList();
                //comboBox_Clientes.Items.Clear();
                //comboBox_Clientes.DisplayMember = "Nome";
                //comboBox_Clientes.DataSource = clientes;
                //comboBox_Clientes.Refresh();
            }
        }

        private void CarregarProdutos()
        {
            using (var contexto = new MiniErpContext())
            {
                DataTable dt = new DataTable();
                var produtos = contexto.Produtos.ToList();
                dataGridView_Produtos.DataSource = produtos;
            }
        }

        private void button_RealizarVenda_Click(object sender, EventArgs e)
        {

        }

        private void button_AdicionarItem_Click(object sender, EventArgs e)
        {
            AdicionarListaPedido();
        }

        private void AdicionarListaPedido()
        {
            //Valor da celula
            MessageBox.Show(dataGridView_Produtos.CurrentCell.Value.ToString());
            //MessageBox.Show(dataGridView_Produtos.CurrentRow.Cells.ToString());

            //dataGridView_ItemPedido.DataMember = "Nome";
            //dataGridView_ItemPedido.DataMember = "Quantidade";
            //dataGridView_ItemPedido.DataMember = "ValorTotal";

            dataGridView_ItemPedido.DataSource = dataGridView_Produtos.CurrentRow.Cells;
        }

        private void button_BuscarCliente_Click(object sender, EventArgs e)
        {
            using (var contexto = new MiniErpContext())
            {
                var clientes = contexto.Clientes.ToList();
                if (String.IsNullOrEmpty(textBox_BuscarCliente.Text))
                {
                    dataGridView_Clientes.DataSource = clientes;
                }
                else
                {
                    var listaClientes = contexto.Clientes.Where(cli =>
                    cli.Nome.Contains(textBox_BuscarCliente.Text)).ToList();
                    dataGridView_Clientes.DataSource = listaClientes;
                }
            }
        }

        private void button_BuscarProduto_Click(object sender, EventArgs e)
        {
            using (var contexto = new MiniErpContext())
            {
                var produtos = contexto.Produtos.ToList();

                if (String.IsNullOrEmpty(textBox_BuscarProduto.Text))
                {
                    dataGridView_Produtos.DataSource = produtos;
                }
                else
                {
                    var listaProdutos = contexto.Produtos.Where(prod =>
                    prod.Nome.Contains(textBox_BuscarProduto.Text)).ToList();
                    dataGridView_Produtos.DataSource = listaProdutos;
                }
            }
        }

        private void button_SelecionarCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView_Clientes.SelectedRows[0].Cells[0].Value.ToString());
            //dataGridView_Clientes.Rows[]
        }
    }
}
