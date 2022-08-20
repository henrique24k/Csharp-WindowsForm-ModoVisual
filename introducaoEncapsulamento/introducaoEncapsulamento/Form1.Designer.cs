
namespace introducaoEncapsulamento
{
    partial class Form1
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
            this.rbLeite = new System.Windows.Forms.RadioButton();
            this.rbMartelo = new System.Windows.Forms.RadioButton();
            this.rbProtetorSolar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbLeite
            // 
            this.rbLeite.AutoSize = true;
            this.rbLeite.Location = new System.Drawing.Point(12, 70);
            this.rbLeite.Name = "rbLeite";
            this.rbLeite.Size = new System.Drawing.Size(69, 24);
            this.rbLeite.TabIndex = 0;
            this.rbLeite.TabStop = true;
            this.rbLeite.Text = "Leite";
            this.rbLeite.UseVisualStyleBackColor = true;
            // 
            // rbMartelo
            // 
            this.rbMartelo.AutoSize = true;
            this.rbMartelo.Location = new System.Drawing.Point(12, 143);
            this.rbMartelo.Name = "rbMartelo";
            this.rbMartelo.Size = new System.Drawing.Size(87, 24);
            this.rbMartelo.TabIndex = 1;
            this.rbMartelo.TabStop = true;
            this.rbMartelo.Text = "Martelo";
            this.rbMartelo.UseVisualStyleBackColor = true;
            // 
            // rbProtetorSolar
            // 
            this.rbProtetorSolar.AutoSize = true;
            this.rbProtetorSolar.Location = new System.Drawing.Point(12, 220);
            this.rbProtetorSolar.Name = "rbProtetorSolar";
            this.rbProtetorSolar.Size = new System.Drawing.Size(132, 24);
            this.rbProtetorSolar.TabIndex = 2;
            this.rbProtetorSolar.TabStop = true;
            this.rbProtetorSolar.Text = "Protetor Solar";
            this.rbProtetorSolar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor inicial";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(102, 288);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(299, 26);
            this.txtValor.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 333);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 36);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(8, 381);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(90, 20);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbProtetorSolar);
            this.Controls.Add(this.rbMartelo);
            this.Controls.Add(this.rbLeite);
            this.Name = "Form1";
            this.Text = "Calcular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbLeite;
        private System.Windows.Forms.RadioButton rbMartelo;
        private System.Windows.Forms.RadioButton rbProtetorSolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
    }
}

