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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniERP
{
    public partial class Form_Cliente : Form
    {
        public Form_Cliente()
        {
            InitializeComponent();
            comboBox_Sexo.SelectedItem = comboBox_Sexo.SelectedIndex = 0;
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void salvar()
        {
            using (var contexto = new MiniErpContext())
            {
                Cliente cliente = new Cliente();
                cliente.Nome = textBox_Nome.Text;
                cliente.DataNascimento = maskedTextBox_DataNascimento.Text;
                cliente.Telefone = maskedTextBox_Telefone.Text;
                cliente.Sexo = comboBox_Sexo.SelectedItem.ToString();


                contexto.Clientes.Add(cliente);
                contexto.SaveChanges();

                MessageBox.Show("Cliente adicionado com sucesso!");
                listar();
            }
        }

        private void listar()
        {
            using (var contexto = new MiniErpContext())
            {
                var clientes = contexto.Clientes.ToList();
                if (String.IsNullOrEmpty(textBox_Buscar.Text))
                {
                    dataGridView_Clientes.DataSource = clientes;
                }
                else
                {
                    var listaClientes = contexto.Clientes.Where(cli => 
                    cli.Nome.Contains(textBox_Buscar.Text)).ToList();
                    dataGridView_Clientes.DataSource = listaClientes;
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

        private void button_Editar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    using (var contexto = new MiniErpContext())
            //    {
            //        var id = 
            //        var cliente = contexto.Clientes.Find(id);
            //    }
            //}
            //catch (Exception ex)
            //{

            //    throw;
            //}
        }
    }
}
