using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjetoAulaYuri.Personagens;
using ProjetoAulaYuri.Itens;

namespace ProjetoAulaYuri
{
    public partial class Form1 : Form
    {
        private Personagem guerreiro = null;

        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Item> ItemP1 = new List<Item>();

            ItemP1.Add(new Item() { 
                    Nome = "Espada Valorian",
                    Raridade = "Raro",
                    Tipo = "Low Range"
            });

            ItemP1.Add(new Item()
            {
                Nome = "Espada Valorian",
                Raridade = "Raro",
                Tipo = "Low Range"
            });

            ItemP1.Add(new Item()
            {
                Nome = "Espada Valorian",
                Raridade = "Raro",
                Tipo = "Low Range"
            });

            ItemP1.Add(new Item()
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
                    Itens = ItemP1
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
                ItemAtaque Item = new ItemAtaque();
                Item.Ataque = 50; //value

                form2 = new Form2(guerreiro);
            }

            FormLuta formLuta = new FormLuta(guerreiro);
            formLuta.Show();

            form2.Show();
        }
    }
}
