using ProjetoAulaYuriWpf.Models.Itens;
using ProjetoAulaYuriWpf.Models.Personagem.Perfil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjetoAulaYuriWpf.Views.MochilaViews
{
    /// <summary>
    /// Lógica interna para Mochila.xaml
    /// </summary>
    public partial class Mochila : Window
    {
        public Mochila(PerfilJogador perfilJogador)
        {
            InitializeComponent();

            this.DataContext = perfilJogador;

            ((PerfilJogador)this.DataContext).Gear.ConsumivelHP = new ItemConsumivelHealthPotion();

            dgvItensMochila.ItemsSource = perfilJogador.Bag.Itens;
        }

        private void btnItem_Click(object sender, RoutedEventArgs e)
        {
            if (dgvItensMochila.SelectedItem != null)
            {
                ((PerfilJogador)this.DataContext).Gear.ConsumivelHP.ImageUrl = ((ItemConsumivelHealthPotion)dgvItensMochila.SelectedItem).ImageUrl;
            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
