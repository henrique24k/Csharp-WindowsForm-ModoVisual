
namespace introClasseAbstrata
{
    partial class rbDw
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.rbP = new System.Windows.Forms.RadioButton();
            this.btnReajustar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salario";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(63, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(348, 26);
            this.txtNome.TabIndex = 2;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(63, 165);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(206, 26);
            this.txtSalario.TabIndex = 3;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Location = new System.Drawing.Point(63, 212);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(98, 24);
            this.rbD.TabIndex = 4;
            this.rbD.TabStop = true;
            this.rbD.Text = "Designer";
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // rbP
            // 
            this.rbP.AutoSize = true;
            this.rbP.Location = new System.Drawing.Point(63, 263);
            this.rbP.Name = "rbP";
            this.rbP.Size = new System.Drawing.Size(126, 24);
            this.rbP.TabIndex = 5;
            this.rbP.TabStop = true;
            this.rbP.Text = "Programador";
            this.rbP.UseVisualStyleBackColor = true;
            // 
            // btnReajustar
            // 
            this.btnReajustar.Location = new System.Drawing.Point(63, 360);
            this.btnReajustar.Name = "btnReajustar";
            this.btnReajustar.Size = new System.Drawing.Size(126, 38);
            this.btnReajustar.TabIndex = 6;
            this.btnReajustar.Text = "Reajustar";
            this.btnReajustar.UseVisualStyleBackColor = true;
            this.btnReajustar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(66, 420);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(82, 20);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(63, 313);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(172, 24);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "DesenvolvedorWeb";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbDw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnReajustar);
            this.Controls.Add(this.rbP);
            this.Controls.Add(this.rbD);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rbDw";
            this.Text = "Polimorfismo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbP;
        private System.Windows.Forms.Button btnReajustar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

