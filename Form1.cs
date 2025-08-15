using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // verificar se txbProduto está vazio:
            if (txbProduto.Text.Length == 0)
            {
                MessageBox.Show("O nome do produto não pode estar vazio",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Mudar a cor do fundo e a cor da Letra:
                txbProduto.BackColor = Color.Red;
                txbProduto.ForeColor = Color.White;
            }
            else if (txbProduto.Text.Length < 2)
            {
                MessageBox.Show("O nome do produto Precisa ter 2 letras!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbProduto.BackColor = Color.Red;
                txbProduto.ForeColor = Color.White;
            }
            else 
            {
                // Verificar se o item está na Lista:
                if (libCompras.Items.Contains(txbProduto.Text))
                {
                    MessageBox.Show($"Já existe {txbProduto.Text} na Lista",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {


                    // Adicionar o item na Lista:
                    libCompras.Items.Add(txbProduto.Text);
                    // Mostrar a mensagem de ssucesso:
                    MessageBox.Show($"{txbProduto.Text} foi adicionado na Lista de compras!",
                        "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Retornar o txbProduto á cor normal:
                    txbProduto.BackColor = Color.White;
                    txbProduto.ForeColor = Color.Black;

                    // Limpar a lista
                    txbProduto.Text = "";
                    txbProduto.Clear();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Perguntar se realmente quer apagar:
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja apagar tudo?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           
            // Se optar por "Sim", apagar:
            if (resposta == DialogResult.Yes)
            {
                libCompras.Items.Clear();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Verificar se o  usuário não selecionou nada:
            if (libCompras.SelectedIndex == -1)
            {
                MessageBox.Show($"Selecione um item para remover!",
                       "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                // Salvar temporariamente o nome do item que será removido:
                string itemRemovido = libCompras.SelectedItem.ToString();
                // Remover o item selecionado:
                libCompras.Items.RemoveAt(libCompras.SelectedIndex);
                MessageBox.Show($"{itemRemovido} foi removido da Lista!",
                       "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        private void txbProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // "Pressionar o btnAdicionar
                btnAdicionar.PerformClick();
            }
        }
    }
}
