using ProjetoAulaYuriWpf.Models.Itens;
using ProjetoAulaYuriWpf.Models.Personagem;
using ProjetoAulaYuriWpf.Models.Personagem.Perfil;
using ProjetoAulaYuriWpf.Views.MochilaViews;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetoAulaYuriWpf
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMochila_Click(object sender, RoutedEventArgs e)
        {
            Mochila mochila = new Mochila(ConstruirJogador());
            mochila.ShowDialog();
        }

        private void btnPerfil_Click(object sender, RoutedEventArgs e)
        {
            Views.PerfilViews.Perfil perfil = new Views.PerfilViews.Perfil(ConstruirJogador());
            perfil.Show();
        }

        private void btnBatalha_Click(object sender, RoutedEventArgs e)
        {

        }

        public PerfilJogador ConstruirJogador()
        {
            List<Item> ItemP1 = new List<Item>();

            ItemP1.Add(new ItemArmaPrincipal()
            {
                Nome = "Espada Valorian",
                Raridade = "Raro",
                ImageUrl = @"F:\workspace\ProjetoAulaYuriWpf\bin\Debug\img\itens\nomeitem_sword.png"
            });

            ItemP1.Add(new ItemArmaSecundaria()
            {
                Nome = "Espada Valorian",
                Raridade = "Raro",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQzgF4UgL7tKPbXO7u-yN10cYcMWQDj0B0HfQ&usqp=CAU"
            });

            ItemP1.Add(new ItemBota()
            {
                Nome = "Espada Valorian",
                Raridade = "Raro",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQzgF4UgL7tKPbXO7u-yN10cYcMWQDj0B0HfQ&usqp=CAU"
            });

            ItemP1.Add(new ItemElmo()
            {
                Nome = "Espada Valorian",
                Raridade = "Raro",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQzgF4UgL7tKPbXO7u-yN10cYcMWQDj0B0HfQ&usqp=CAU"
            });

            ItemP1.Add(new ItemConsumivelHealthPotion()
            {
                Id = 25,
                Nome = "HP Potion (Extra Large)",
                Descrição = "Ordinary potion.",
                Recover = 275,
                ImageUrl = "https://static.wikia.nocookie.net/blackdesert/images/1/1e/HP_Potion_%28Extra_Large%29.jpg/revision/latest/scale-to-width-down/220?cb=20180408123636",
                CoolDown = TimeSpan.FromMilliseconds(3000)
            });

            var guerreiro = new Guerreiro("GeneralIce")
            {
                Nome = "IceDemon",
                Bag = new Bag
                {
                    Tamanho = 28,
                    Itens = ItemP1
                },
                Gear = new Gears
                {
                    ArmaPrincipal = new ItemArmaPrincipal
                    {
                        Dano = 5,
                        Descrição = "Muito dano !",
                        Nome = "Albatroz",
                        Rank = "2",
                        Raridade = "Raro"
                    }
                },
            };

            return guerreiro;
        }
    }
}
