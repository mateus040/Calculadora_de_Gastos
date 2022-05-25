using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Familiar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            // Entrada de Dados
            double renda = double.Parse(txtRenda.Text);

            double energia = double.Parse(txtEnergia.Text);
            double agua = double.Parse(txtAgua.Text);
            double tv = double.Parse(txtAgua.Text);
            double alimentacao = double.Parse(txtAlimentacao.Text);
            double outros = double.Parse(txtOutros.Text);

            // Processamento
            double gastos = energia + agua + tv + alimentacao + outros;
            double saldo = renda - gastos;

            // Saída de Dados
            lblGastos.Text = gastos.ToString("C");
            lblSaldo.Text = saldo.ToString("C");



        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa as caixas através da propriedade Text
            txtRenda.Clear();
            txtEnergia.Clear();
            txtAgua.Clear();
            txtTV.Clear();
            txtAlimentacao.Clear();
            txtOutros.Clear();

            // Move o texto Zero para a label
            lblGastos.Text = "R$ 0,00";
            lblSaldo.Text = "R$ 0,00";

            // Move o cursor para o textBox 
            txtRenda.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // Fecha o Formulário
            Application.Exit();
        }
    }
}
