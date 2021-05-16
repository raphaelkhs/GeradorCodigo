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
    public partial class Gerador : Form
    {
        public Gerador()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {

            //verificar se algum dos checks estão selecionados
            if (checkMaiscula.Checked || checkMinusculas.Checked || checkNumeros.Checked || checkCaracteres.Checked)
            {
                //check se os txt tao vazio
                if (!String.IsNullOrEmpty(txtQtd.Text) && !String.IsNullOrEmpty(txtTamanho.Text))
                {                    
                    int tamanho = int.Parse(txtTamanho.Text);
                    int qtd = int.Parse(txtQtd.Text);
                    string caracteres = "";
                    int qtdgerada = 0;

                    if (checkMaiscula.Checked)
                        caracteres += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                    else if (checkMinusculas.Checked)
                        caracteres += "abcdefghijklmnopqrstuvwxyz";

                    else if (checkNumeros.Checked)
                        caracteres += "1234567890";

                    else if (checkCaracteres.Checked)
                        caracteres += "!@#$%&";

                    //apenas prefixo selecionado
                    if (checkPrefixo.Checked && !String.IsNullOrEmpty(txtPrefixo.Text) && !checkSufixo.Checked)
                    {
                        //verificar se o prefixo é menor que o tamanho total atribuido
                        if (txtPrefixo.TextLength < tamanho)
                        {
                            listBox1.Items.Clear();
                            int tamprefixo = txtPrefixo.TextLength;
                            string prefixo = txtPrefixo.Text;
                            var random = new Random();
                            for (int i = 0; i < qtd; i++)
                            {
                                string result = new string(Enumerable.Repeat(caracteres, (tamanho - tamprefixo)).Select(s => s[random.Next(s.Length)]).ToArray());
                                if (listBox1.FindString(result) == -1)
                                {
                                    listBox1.Items.Add(prefixo + result);
                                    qtdgerada++;
                                }
                                result = "";
                            }
                        }
                        else
                            MessageBox.Show("O prefixo tem que ser menor que o tamanho total, e não pode estar em branco", "Alerta Vermelho!");
                    }
                    //apenas sufixo selecionado
                    else if (checkSufixo.Checked && !String.IsNullOrEmpty(txtSufixo.Text) && !checkPrefixo.Checked)
                    {
                        //verificar se o sufixo é menor que o tamanho total atribuido
                        if (txtSufixo.TextLength < tamanho)
                        {
                            listBox1.Items.Clear();
                            int tamsufixo = txtSufixo.TextLength;
                            string sufixo = txtSufixo.Text;
                            var random = new Random();
                            for (int i = 0; i < qtd; i++)
                            {
                                string result = new string(Enumerable.Repeat(caracteres, (tamanho - tamsufixo)).Select(s => s[random.Next(s.Length)]).ToArray());
                                if (listBox1.FindString(result) == -1)
                                {
                                    listBox1.Items.Add(result + sufixo);
                                    qtdgerada++;
                                }
                                result = "";
                            }
                        }
                        else
                            MessageBox.Show("O sufixo tem que ser menor que o tamanho total, e não pode estar em branco", "Alerta Vermelho!");
                    }
                    //Sufixo e prefixo selecionado
                    else if (checkSufixo.Checked && !String.IsNullOrEmpty(txtSufixo.Text) && checkPrefixo.Checked && !String.IsNullOrEmpty(txtPrefixo.Text))
                    {
                        //verificar se a soma do prefixo com o sufixo é menor que o tamanho total atribuido
                        if ((txtPrefixo.TextLength + txtSufixo.TextLength) < tamanho)
                        {
                            listBox1.Items.Clear();
                            int tamsomasufixoeprefixo = txtSufixo.TextLength + txtPrefixo.TextLength;
                            string sufixo = txtSufixo.Text;
                            string prefixo = txtPrefixo.Text;

                            var random = new Random();
                            for (int i = 0; i < qtd; i++)
                            {
                                string result = new string(Enumerable.Repeat(caracteres, (tamanho - tamsomasufixoeprefixo)).Select(s => s[random.Next(s.Length)]).ToArray());
                                if (listBox1.FindString(result) == -1)
                                {
                                    listBox1.Items.Add(prefixo + result + sufixo);
                                    qtdgerada++;
                                }
                                result = "";
                            }
                        }
                        else
                            MessageBox.Show("A soma do tamanho do prefixo e do sufixo tem que ser menor que o tamanho total, e não podem estar em branco", "Alerta Vermelho!");
                    }
                    //SEM PREFIXO E SUFIXO
                    else if (!checkPrefixo.Checked && !checkSufixo.Checked)
                    {    
                        var random = new Random();
                        for (int i = 0; i < qtd; i++)
                        {
                            listBox1.Items.Clear();
                            string result = new string(Enumerable.Repeat(caracteres, tamanho).Select(s => s[random.Next(s.Length)]).ToArray());
                            if (listBox1.FindString(result) == -1)
                            {
                                listBox1.Items.Add(result);
                                qtdgerada++;
                            }
                            result = "";
                        }                        
                    }
                    //Estão ambos selecionados mas um está sem texto
                    else
                    {
                        MessageBox.Show("Os campos de Prefixo e Sufixo não podem estar em branco", "Alerta vermelho!");
                    }
                    lblQtd.Text = qtdgerada.ToString();
                }
                else
                {
                    MessageBox.Show("Verifique se os textbox de quantidade e tamanho estão preenchidos.", "Alerta Vermelho!");
                }
            }
            else
                MessageBox.Show("Selecione o tipo dos caracteres do código", "Alerta Vermelho!");
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
                e.Handled = true;            
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txt apenas numeros
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void checkPrefixo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPrefixo.Checked)
                txtPrefixo.Visible = true;

            else            
                txtPrefixo.Visible = false;            
        }

        private void checkSufixo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSufixo.Checked)
                txtSufixo.Visible = true;
            
            else            
                txtSufixo.Visible = false;            
        }
    }
}
