﻿using System;
using System.Windows.Forms;
using ProjetoAulaYuri.Personagens;

namespace ProjetoAulaYuri
{
    public partial class Form2 : Form
    {
        public Personagem personagem;

        public Form2(Personagem v)
        {
            InitializeComponent();
            this.personagem = v;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = personagem.Nome;
            label3.Text = personagem.ClassePersonagem;

            foreach (var item in personagem.Bag.Itens)
            {
                listBox1.Items.Add(item.Nome);
            }

            label2.Text = $"{personagem.Bag.Itens.Count} / {personagem.Bag.Tamanho}";
        }
    }
}
