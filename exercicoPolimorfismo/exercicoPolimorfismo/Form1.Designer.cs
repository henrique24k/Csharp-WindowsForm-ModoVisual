
namespace exercicoPolimorfismo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbCe = new System.Windows.Forms.RadioButton();
            this.rbCp = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.lblSaldoCe = new System.Windows.Forms.Label();
            this.lblSaldoCp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbCe
            // 
            this.rbCe.AutoSize = true;
            this.rbCe.BackColor = System.Drawing.Color.Transparent;
            this.rbCe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCe.ForeColor = System.Drawing.SystemColors.Control;
            this.rbCe.Location = new System.Drawing.Point(55, 29);
            this.rbCe.Name = "rbCe";
            this.rbCe.Size = new System.Drawing.Size(155, 24);
            this.rbCe.TabIndex = 0;
            this.rbCe.TabStop = true;
            this.rbCe.Text = "Conta Especial";
            this.rbCe.UseVisualStyleBackColor = false;
            // 
            // rbCp
            // 
            this.rbCp.AutoSize = true;
            this.rbCp.BackColor = System.Drawing.Color.Transparent;
            this.rbCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCp.ForeColor = System.Drawing.SystemColors.Control;
            this.rbCp.Location = new System.Drawing.Point(275, 29);
            this.rbCp.Name = "rbCp";
            this.rbCp.Size = new System.Drawing.Size(167, 24);
            this.rbCp.TabIndex = 1;
            this.rbCp.TabStop = true;
            this.rbCp.Text = "Conta Poupança";
            this.rbCp.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(43, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 26);
            this.textBox1.TabIndex = 2;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositar.Location = new System.Drawing.Point(54, 388);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(92, 45);
            this.btnDepositar.TabIndex = 3;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacar.Location = new System.Drawing.Point(369, 388);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(103, 47);
            this.btnSacar.TabIndex = 4;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // lblSaldoCe
            // 
            this.lblSaldoCe.AutoSize = true;
            this.lblSaldoCe.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldoCe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoCe.Location = new System.Drawing.Point(59, 467);
            this.lblSaldoCe.Name = "lblSaldoCe";
            this.lblSaldoCe.Size = new System.Drawing.Size(89, 20);
            this.lblSaldoCe.TabIndex = 5;
            this.lblSaldoCe.Text = "Saldo CE:";
            // 
            // lblSaldoCp
            // 
            this.lblSaldoCp.AutoSize = true;
            this.lblSaldoCp.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldoCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoCp.Location = new System.Drawing.Point(365, 467);
            this.lblSaldoCp.Name = "lblSaldoCp";
            this.lblSaldoCp.Size = new System.Drawing.Size(88, 20);
            this.lblSaldoCp.TabIndex = 6;
            this.lblSaldoCp.Text = "Saldo CP:";
            this.lblSaldoCp.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(509, 539);
            this.Controls.Add(this.lblSaldoCp);
            this.Controls.Add(this.lblSaldoCe);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbCp);
            this.Controls.Add(this.rbCe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Conta Nubank";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCe;
        private System.Windows.Forms.RadioButton rbCp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Label lblSaldoCe;
        private System.Windows.Forms.Label lblSaldoCp;
    }
}

