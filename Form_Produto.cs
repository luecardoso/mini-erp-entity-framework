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
            listar();
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void listar()
        {
            textBox_Id.Text = null;
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
            if (textBox_Id.Text == null || textBox_Id.Text == string.Empty)
            {
                salvar();
            }
            else
                salvarAlterado();

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
                    produto.FkFornecedor = int.Parse(comboBox_Fornecedor.Text);
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

        private void salvarAlterado()
        {
            //MessageBox.Show(textBox_Id.Text.ToString());
            //try
            //{
            using (var contexto = new MiniErpContext())
                {
                    int id = int.Parse(textBox_Id.Text);
                    Produto produtoAletrado = contexto.Produtos.Find(id);
                    produtoAletrado.Nome = textBox_Nome.Text;
                    produtoAletrado.Descricao = textBox_Descricao.Text;
                    produtoAletrado.Quantidade = int.Parse(textBox_Quantidade.Text) ;
                    produtoAletrado.Preco = float.Parse (textBox_Preco.Text);
                    produtoAletrado.FkFornecedor = int.Parse(comboBox_Fornecedor.Text);
                    contexto.Produtos.Update(produtoAletrado);
                    contexto.SaveChanges();
                    MessageBox.Show("Fornecedor editado com sucesso!");
                    listar();
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Erro: "+ex);
            //}
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

        private void button_Editar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void editar()
        {
            if (dataGridView_Produtos.SelectedRows.Count < 1)
            {
                MessageBox.Show("Selecione um produto para editar!");
            }
            else
            {
                textBox_Id.Text = dataGridView_Produtos.SelectedRows[0].Cells[0].Value.ToString();
                textBox_Nome.Text = dataGridView_Produtos.SelectedRows[0].Cells[1].Value.ToString();
                textBox_Quantidade.Text = dataGridView_Produtos.SelectedRows[0].Cells[2].Value.ToString();
                textBox_Descricao.Text = dataGridView_Produtos.SelectedRows[0].Cells[3].Value == null?
                  string.Empty : dataGridView_Produtos.SelectedRows[0].Cells[3].Value.ToString();
                textBox_Preco.Text = dataGridView_Produtos.SelectedRows[0].Cells[4].Value.ToString();

                comboBox_Fornecedor.SelectedItem = dataGridView_Produtos.SelectedRows[0].Cells[5].Value.ToString();
            }
        }
    }
}
