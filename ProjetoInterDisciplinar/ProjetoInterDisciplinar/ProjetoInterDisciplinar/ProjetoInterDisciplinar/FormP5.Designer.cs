namespace ProjetoInterDisciplinar
{
    partial class FormP5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormP5));
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rb15 = new System.Windows.Forms.RadioButton();
            this.rb14 = new System.Windows.Forms.RadioButton();
            this.rb13 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(723, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 55);
            this.label2.TabIndex = 39;
            this.label2.Text = "5";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 424);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(800, 23);
            this.progressBar1.TabIndex = 38;
            this.progressBar1.Value = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(38, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Qual a distribuição Linux mais utilizada?";
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.Purple;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProximo.Location = new System.Drawing.Point(678, 382);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(96, 39);
            this.btnProximo.TabIndex = 32;
            this.btnProximo.Text = "Next";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // rb15
            // 
            this.rb15.AutoSize = true;
            this.rb15.BackColor = System.Drawing.Color.Transparent;
            this.rb15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb15.ForeColor = System.Drawing.Color.White;
            this.rb15.Location = new System.Drawing.Point(42, 326);
            this.rb15.Name = "rb15";
            this.rb15.Size = new System.Drawing.Size(65, 17);
            this.rb15.TabIndex = 42;
            this.rb15.TabStop = true;
            this.rb15.Text = "Debian";
            this.rb15.UseVisualStyleBackColor = false;
            // 
            // rb14
            // 
            this.rb14.AutoSize = true;
            this.rb14.BackColor = System.Drawing.Color.Transparent;
            this.rb14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb14.ForeColor = System.Drawing.Color.White;
            this.rb14.Location = new System.Drawing.Point(42, 262);
            this.rb14.Name = "rb14";
            this.rb14.Size = new System.Drawing.Size(83, 20);
            this.rb14.TabIndex = 41;
            this.rb14.TabStop = true;
            this.rb14.Text = "Mx Linux";
            this.rb14.UseVisualStyleBackColor = false;
            // 
            // rb13
            // 
            this.rb13.AutoSize = true;
            this.rb13.BackColor = System.Drawing.Color.Transparent;
            this.rb13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb13.ForeColor = System.Drawing.Color.White;
            this.rb13.Location = new System.Drawing.Point(42, 205);
            this.rb13.Name = "rb13";
            this.rb13.Size = new System.Drawing.Size(73, 20);
            this.rb13.TabIndex = 40;
            this.rb13.TabStop = true;
            this.rb13.Text = "Ubuntu";
            this.rb13.UseVisualStyleBackColor = false;
            // 
            // FormP5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rb15);
            this.Controls.Add(this.rb14);
            this.Controls.Add(this.rb13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProximo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormP5";
            this.Text = "5° Pergunta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rb15;
        private System.Windows.Forms.RadioButton rb14;
        private System.Windows.Forms.RadioButton rb13;
    }
}