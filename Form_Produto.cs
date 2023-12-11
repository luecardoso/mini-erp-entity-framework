using MiniERP.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP
{
    public partial class Form_Produto : Form
    {
        public Form_Produto()
        {
            InitializeComponent();
            CarregarFornecedores();
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void listar()
        {
            using (var contexto = new MiniErpContext())
            {
                var produtos = contexto.Produtos.ToList();

                if (String.IsNullOrEmpty(textBox_Buscar.Text))
                {
                    dataGridView_Produtos.DataSource = produtos;
                }
                else
                {
                    var listaProdutos = contexto.Produtos.Where(prod =>
                    prod.Nome.Contains(textBox_Buscar.Text)).ToList();
                    dataGridView_Produtos.DataSource = listaProdutos;
                }
            }
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void salvar()
        {
            try
            {
                using (var contexto = new MiniErpContext())
                {
                    Produto produto = new Produto();
                    produto.Nome = textBox_Nome.Text;
                    produto.Quantidade = int.Parse(textBox_Quantidade.Text);
                    produto.Preco = float.Parse(textBox_Preco.Text);

                    //var id = comboBox_Fornecedor.SelectedIndex + 1;
                    //var id = contexto.Fornecedors.Where(f => f.)
                    //var fornecedor = contexto.Fornecedors.Find(id);
                    //produto.FkFornecedor = fornecedor.Id;
                    produto.Descricao = textBox_Descricao.Text;



                    contexto.Produtos.Add(produto);
                    contexto.SaveChanges();

                    MessageBox.Show("Produto adicionado com sucesso!");
                    listar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o produto");
                MessageBox.Show("Erro: " + ex);

            }
        }

        private void CarregarFornecedores()
        {
            using (var contexto = new MiniErpContext())
            {
                var fornecedores = contexto.Fornecedors.ToList();
                comboBox_Fornecedor.Items.Clear();
                comboBox_Fornecedor.DisplayMember = "Id";
                comboBox_Fornecedor.DataSource = fornecedores;
                comboBox_Fornecedor.Refresh();
            }
        }

        private void CarregarCategorias()
        {

        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {
            Form_Principal principal = new Form_Principal();
            principal.Show();
            this.Hide();
        }
    }
}
