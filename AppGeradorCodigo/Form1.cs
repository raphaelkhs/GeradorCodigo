using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGeradorCodigo
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

        private void btnGerar_Click(object sender, EventArgs e)
        {
            //check se os txt tao vazio
            if (!String.IsNullOrEmpty(txtQtd.Text) && !String.IsNullOrEmpty(txtTamanho.Text))
            {


                listBox1.Items.Clear();

                int tamanho = int.Parse(txtTamanho.Text);
                int qtd = int.Parse(txtQtd.Text);
                string caracteres = "";
                int qtdgerada = 0;

                if (checkMaiscula.Checked)
                {
                    caracteres += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                }

                if (checkMinusculas.Checked)
                {
                    caracteres += "abcdefghijklmnopqrstuvwxyz";
                }

                if (checkNumeros.Checked)
                {
                    caracteres += "1234567890";
                }

                if (checkCaracteres.Checked)
                {
                    caracteres += "!@#$%&";
                }

                var random = new Random();
                for (int i = 0; i < qtd; i++)
                {
                    string result = new string(Enumerable.Repeat(caracteres, tamanho).Select(s => s[random.Next(s.Length)]).ToArray());
                    if (listBox1.FindString(result) == -1)
                    {
                        listBox1.Items.Add(result);
                        qtdgerada++;
                    }
                    result = "";
                }
                lblQtd.Text = qtdgerada.ToString();
            }
            else
            {
                MessageBox.Show("Verifique se os textbox de quantidade e tamanho estão preenchidos.", "Alerta Vermelho!");
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                string lista = "";

                foreach (var item in listBox1.Items)
                {
                    lista += item.ToString();
                    lista += "\n";
                }

                Clipboard.SetText(lista);
            }

            else            
                MessageBox.Show("A lista está vazia!", "Alerta Vermelho!");
            
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            lblQtd.Text = "0";
        }

        private void txtTamanho_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txt apenas numeros
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txt apenas numeros
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
