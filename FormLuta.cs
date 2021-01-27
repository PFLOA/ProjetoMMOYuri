using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAulaYuri
{
    public partial class FormLuta : Form
    {
        private Personagem guerreiro;

        public FormLuta(Personagem guerreiro)
        {
            InitializeComponent();

            this.guerreiro = guerreiro;

            label7.Text = "200 / 200";

            progressBar1.Maximum = guerreiro.HealthPoint;
            progressBar1.Value = guerreiro.HealthPoint;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dano = guerreiro.Atacar();

            if (dano < progressBar2.Value)
            {
                progressBar2.Value -= dano;
            }
            else
            {
                progressBar2.Value = 0;
            }

            label7.Text = $"{progressBar2.Value} / 200";
        }
    }
}
