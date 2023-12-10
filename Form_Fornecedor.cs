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
    public partial class Form_Fornecedor : Form
    {
        public Form_Fornecedor()
        {
            InitializeComponent();
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void salvar()
        {
            using (var contexto = new MiniErpContext())
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.Nome = textBox_Nome.Text;



                contexto.Fornecedors.Add(fornecedor);
                contexto.SaveChanges();

                MessageBox.Show("Fornecedor adicionado com sucesso!");
                listar();
            }
        }

        private void listar()
        {
            using (var contexto = new MiniErpContext())
            {
                DataTable dt = new DataTable();
                var fornecedores = contexto.Fornecedors.ToList();

                if (String.IsNullOrEmpty(textBox_Buscar.Text))
                {
                    dataGridView_Fornecedores.DataSource = fornecedores;
                }
                else
                {
                    var listaFornecedor = contexto.Fornecedors.Where(fornecedor => 
                    fornecedor.Nome.Contains(textBox_Buscar.Text)).ToList();
                    dataGridView_Fornecedores.DataSource = listaFornecedor;
                }
            }
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void button_Voltar_Click(object sender, EventArgs e)
        {
            Form_Principal principal = new Form_Principal();
            principal.Show();
            this.Hide();
        }
    }
}
