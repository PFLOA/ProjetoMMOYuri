namespace ProjetoAulaYuri
{
    partial class FormLuta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hpGuerreiroBar = new System.Windows.Forms.ProgressBar();
            this.hpBossBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.hpBossLabel = new System.Windows.Forms.Label();
            this.hpGuerreiroLabel = new System.Windows.Forms.Label();
            this.bossDanoRecebidoLabel = new System.Windows.Forms.Label();
            this.guerreiroDanoRecebidoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(553, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "label6";
            // 
            // hpGuerreiroBar
            // 
            this.hpGuerreiroBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.hpGuerreiroBar.Location = new System.Drawing.Point(22, 10);
            this.hpGuerreiroBar.Name = "hpGuerreiroBar";
            this.hpGuerreiroBar.Size = new System.Drawing.Size(237, 23);
            this.hpGuerreiroBar.TabIndex = 6;
            // 
            // hpBossBar
            // 
            this.hpBossBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.hpBossBar.Location = new System.Drawing.Point(351, 10);
            this.hpBossBar.MarqueeAnimationSpeed = 20;
            this.hpBossBar.Name = "hpBossBar";
            this.hpBossBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hpBossBar.RightToLeftLayout = true;
            this.hpBossBar.Size = new System.Drawing.Size(237, 23);
            this.hpBossBar.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Atacar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hpBossLabel
            // 
            this.hpBossLabel.AutoSize = true;
            this.hpBossLabel.BackColor = System.Drawing.Color.Transparent;
            this.hpBossLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hpBossLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.hpBossLabel.Location = new System.Drawing.Point(458, 15);
            this.hpBossLabel.Name = "hpBossLabel";
            this.hpBossLabel.Size = new System.Drawing.Size(35, 13);
            this.hpBossLabel.TabIndex = 9;
            this.hpBossLabel.Text = "label7";
            // 
            // hpGuerreiroLabel
            // 
            this.hpGuerreiroLabel.AutoSize = true;
            this.hpGuerreiroLabel.BackColor = System.Drawing.Color.Transparent;
            this.hpGuerreiroLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hpGuerreiroLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.hpGuerreiroLabel.Location = new System.Drawing.Point(116, 15);
            this.hpGuerreiroLabel.Name = "hpGuerreiroLabel";
            this.hpGuerreiroLabel.Size = new System.Drawing.Size(35, 13);
            this.hpGuerreiroLabel.TabIndex = 11;
            this.hpGuerreiroLabel.Text = "label7";
            // 
            // bossDanoRecebidoLabel
            // 
            this.bossDanoRecebidoLabel.AutoSize = true;
            this.bossDanoRecebidoLabel.Location = new System.Drawing.Point(351, 40);
            this.bossDanoRecebidoLabel.Name = "bossDanoRecebidoLabel";
            this.bossDanoRecebidoLabel.Size = new System.Drawing.Size(35, 13);
            this.bossDanoRecebidoLabel.TabIndex = 12;
            this.bossDanoRecebidoLabel.Text = "label7";
            // 
            // guerreiroDanoRecebidoLabel
            // 
            this.guerreiroDanoRecebidoLabel.AutoSize = true;
            this.guerreiroDanoRecebidoLabel.Location = new System.Drawing.Point(151, 40);
            this.guerreiroDanoRecebidoLabel.Name = "guerreiroDanoRecebidoLabel";
            this.guerreiroDanoRecebidoLabel.Size = new System.Drawing.Size(35, 13);
            this.guerreiroDanoRecebidoLabel.TabIndex = 13;
            this.guerreiroDanoRecebidoLabel.Text = "label8";
            // 
            // FormLuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 150);
            this.Controls.Add(this.guerreiroDanoRecebidoLabel);
            this.Controls.Add(this.bossDanoRecebidoLabel);
            this.Controls.Add(this.hpGuerreiroLabel);
            this.Controls.Add(this.hpBossLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hpBossBar);
            this.Controls.Add(this.hpGuerreiroBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLuta";
            this.Text = "FormLuta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar hpGuerreiroBar;
        private System.Windows.Forms.ProgressBar hpBossBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label hpBossLabel;
        private System.Windows.Forms.Label hpGuerreiroLabel;
        private System.Windows.Forms.Label bossDanoRecebidoLabel;
        private System.Windows.Forms.Label guerreiroDanoRecebidoLabel;
    }
}