
namespace AppGeradorCodigo
{
    partial class Gerador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTamanho = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.checkMaiscula = new System.Windows.Forms.CheckBox();
            this.checkMinusculas = new System.Windows.Forms.CheckBox();
            this.checkNumeros = new System.Windows.Forms.CheckBox();
            this.checkCaracteres = new System.Windows.Forms.CheckBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtPrefixo = new System.Windows.Forms.TextBox();
            this.txtSufixo = new System.Windows.Forms.TextBox();
            this.checkPrefixo = new System.Windows.Forms.CheckBox();
            this.checkSufixo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(11, 83);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(106, 13);
            this.lblTamanho.TabIndex = 0;
            this.lblTamanho.Text = "Tamanho do Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantidade de Códigos:";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(49, 315);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(102, 53);
            this.btnGerar.TabIndex = 3;
            this.btnGerar.Text = "Gerar Códigos";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(211, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 212);
            this.listBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Códigos Gerados: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gerador de Códigos";
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(123, 80);
            this.txtTamanho.MaxLength = 2;
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(71, 20);
            this.txtTamanho.TabIndex = 7;
            this.txtTamanho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTamanho_KeyPress);
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(139, 106);
            this.txtQtd.MaxLength = 4;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(55, 20);
            this.txtQtd.TabIndex = 8;
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtd_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tipos de caracteres do código:";
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(211, 315);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(102, 53);
            this.btnCopiar.TabIndex = 14;
            this.btnCopiar.Text = "Copiar Lista";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(335, 315);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(102, 53);
            this.btnApagar.TabIndex = 15;
            this.btnApagar.Text = "Apagar Lista";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // checkMaiscula
            // 
            this.checkMaiscula.AutoSize = true;
            this.checkMaiscula.Checked = true;
            this.checkMaiscula.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkMaiscula.Location = new System.Drawing.Point(13, 209);
            this.checkMaiscula.Name = "checkMaiscula";
            this.checkMaiscula.Size = new System.Drawing.Size(111, 17);
            this.checkMaiscula.TabIndex = 16;
            this.checkMaiscula.Text = "Letras Maiúsculas";
            this.checkMaiscula.UseVisualStyleBackColor = true;
            // 
            // checkMinusculas
            // 
            this.checkMinusculas.AutoSize = true;
            this.checkMinusculas.Location = new System.Drawing.Point(13, 232);
            this.checkMinusculas.Name = "checkMinusculas";
            this.checkMinusculas.Size = new System.Drawing.Size(111, 17);
            this.checkMinusculas.TabIndex = 17;
            this.checkMinusculas.Text = "Letras Minúsculas";
            this.checkMinusculas.UseVisualStyleBackColor = true;
            // 
            // checkNumeros
            // 
            this.checkNumeros.AutoSize = true;
            this.checkNumeros.Location = new System.Drawing.Point(13, 255);
            this.checkNumeros.Name = "checkNumeros";
            this.checkNumeros.Size = new System.Drawing.Size(68, 17);
            this.checkNumeros.TabIndex = 18;
            this.checkNumeros.Text = "Números";
            this.checkNumeros.UseVisualStyleBackColor = true;
            // 
            // checkCaracteres
            // 
            this.checkCaracteres.AutoSize = true;
            this.checkCaracteres.Location = new System.Drawing.Point(13, 278);
            this.checkCaracteres.Name = "checkCaracteres";
            this.checkCaracteres.Size = new System.Drawing.Size(125, 17);
            this.checkCaracteres.TabIndex = 19;
            this.checkCaracteres.Text = "Caracteres Especiais";
            this.checkCaracteres.UseVisualStyleBackColor = true;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(367, 80);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(13, 13);
            this.lblQtd.TabIndex = 20;
            this.lblQtd.Text = "0";
            // 
            // txtPrefixo
            // 
            this.txtPrefixo.Location = new System.Drawing.Point(139, 132);
            this.txtPrefixo.MaxLength = 10;
            this.txtPrefixo.Name = "txtPrefixo";
            this.txtPrefixo.Size = new System.Drawing.Size(55, 20);
            this.txtPrefixo.TabIndex = 22;
            this.txtPrefixo.Visible = false;
            // 
            // txtSufixo
            // 
            this.txtSufixo.Location = new System.Drawing.Point(139, 158);
            this.txtSufixo.MaxLength = 10;
            this.txtSufixo.Name = "txtSufixo";
            this.txtSufixo.Size = new System.Drawing.Size(55, 20);
            this.txtSufixo.TabIndex = 24;
            this.txtSufixo.Visible = false;
            // 
            // checkPrefixo
            // 
            this.checkPrefixo.AutoSize = true;
            this.checkPrefixo.Location = new System.Drawing.Point(16, 134);
            this.checkPrefixo.Name = "checkPrefixo";
            this.checkPrefixo.Size = new System.Drawing.Size(115, 17);
            this.checkPrefixo.TabIndex = 25;
            this.checkPrefixo.Text = "Prefixo no Código?";
            this.checkPrefixo.UseVisualStyleBackColor = true;
            this.checkPrefixo.CheckedChanged += new System.EventHandler(this.checkPrefixo_CheckedChanged);
            // 
            // checkSufixo
            // 
            this.checkSufixo.AutoSize = true;
            this.checkSufixo.Location = new System.Drawing.Point(16, 161);
            this.checkSufixo.Name = "checkSufixo";
            this.checkSufixo.Size = new System.Drawing.Size(112, 17);
            this.checkSufixo.TabIndex = 26;
            this.checkSufixo.Text = "Sufixo no Código?";
            this.checkSufixo.UseVisualStyleBackColor = true;
            this.checkSufixo.CheckedChanged += new System.EventHandler(this.checkSufixo_CheckedChanged);
            // 
            // Gerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 375);
            this.Controls.Add(this.checkSufixo);
            this.Controls.Add(this.checkPrefixo);
            this.Controls.Add(this.txtSufixo);
            this.Controls.Add(this.txtPrefixo);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.checkCaracteres);
            this.Controls.Add(this.checkNumeros);
            this.Controls.Add(this.checkMinusculas);
            this.Controls.Add(this.checkMaiscula);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTamanho);
            this.Name = "Gerador";
            this.Text = "Gerador de Códigos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.CheckBox checkMaiscula;
        private System.Windows.Forms.CheckBox checkMinusculas;
        private System.Windows.Forms.CheckBox checkNumeros;
        private System.Windows.Forms.CheckBox checkCaracteres;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtPrefixo;
        private System.Windows.Forms.TextBox txtSufixo;
        private System.Windows.Forms.CheckBox checkPrefixo;
        private System.Windows.Forms.CheckBox checkSufixo;
    }
}

