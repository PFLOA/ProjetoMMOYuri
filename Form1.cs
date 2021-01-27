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
        private Personagem guerreiro = null;
        private Personagem necromante;
        private Mago mago;

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

            guerreiro = new Guerreiro("GeneralIce")
            {
                Bag = new Bag
                {
                    Tamanho = 28,
                    Itens = itensP1
                },
                Gear = new Gears
                {
                    ArmaPrincipal = new ArmaPrincipal
                    {
                        Dano = 5,
                        Descrição = "Muito dano !",
                        Nome = "Albatroz",
                        Rank = "2",
                        Raridade = "Raro",
                        Tipo = "Range"
                    }
                },
            };
        }

        private void btnPersonagem1Atacar_Click(object sender, EventArgs e)
        {
            if (form2 == null)
            {
                ItensAtaque itens = new ItensAtaque();
                itens.Ataque = 50; //value

                form2 = new Form2(guerreiro);
            }

            FormLuta formLuta = new FormLuta(guerreiro);
            formLuta.Show();

            form2.Show();
        }
    }
}
