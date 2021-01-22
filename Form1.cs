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
    public partial class Form1 : Form
    {
        private Personagem personagem1;
        private Personagem personagem2;
        private Personagem personagem3;
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Itens> itensP1 = new List<Itens>();

            itensP1.Add(new Itens() { 
                    Nome = "Espada Valorian",
                    Raridade = "Raro",
                    Tipo = "Low Range"
            });

            itensP1.Add(new Itens()
            {
                Nome = "Espada Valorian",
                Raridade = "Raro",
                Tipo = "Low Range"
            });

            itensP1.Add(new Itens()
            {
                Nome = "Espada Valorian",
                Raridade = "Raro",
                Tipo = "Low Range"
            });

            itensP1.Add(new Itens()
            {
                Nome = "Espada Valorian",
                Raridade = "Raro",
                Tipo = "Low Range"
            });

            personagem1 = new Personagem("IceDemon", "Mago");
            personagem1.Bag = new Bag
            {
                Tamanho = 28,
                Itens = itensP1
            };

            personagem2 = new Personagem("GeneralIce", "Guerreiro");
            personagem3 = new Personagem("Baltazar", "Arqueiro");
        }

        private void btnPersonagem1Atacar_Click(object sender, EventArgs e)
        {
            if (form2 == null)
            {
                form2 = new Form2(personagem1);
                form2.Show();
            }
        }
    }
}
