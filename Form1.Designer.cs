namespace ProjetoAulaYuri
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPersonagem1Atacar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(575, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnPersonagem1Atacar
            // 
            this.btnPersonagem1Atacar.Location = new System.Drawing.Point(12, 113);
            this.btnPersonagem1Atacar.Name = "btnPersonagem1Atacar";
            this.btnPersonagem1Atacar.Size = new System.Drawing.Size(281, 23);
            this.btnPersonagem1Atacar.TabIndex = 1;
            this.btnPersonagem1Atacar.Text = "Ataque P1";
            this.btnPersonagem1Atacar.UseVisualStyleBackColor = true;
            this.btnPersonagem1Atacar.Click += new System.EventHandler(this.btnPersonagem1Atacar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 145);
            this.Controls.Add(this.btnPersonagem1Atacar);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPersonagem1Atacar;
    }
}

