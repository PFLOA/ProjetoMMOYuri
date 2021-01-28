using System;
using System.Windows.Forms;
using ProjetoAulaYuri.Personagens;
using ProjetoAulaYuri.Bosses;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Threading;

namespace ProjetoAulaYuri
{
    public partial class FormLuta : Form
    {
        private Personagem guerreiro;
        private Boss Orc;
        BackgroundWorker worker = null;


        public FormLuta(Personagem guerreiro)
        {
            InitializeComponent();

            Orc = new Boss();
            Orc.HealtPoint = 550;

            this.guerreiro = guerreiro;

            hpBossLabel.Text = $"{Orc.HealtPoint } / {Orc.HealtPoint }";
            hpGuerreiroLabel.Text = $"{guerreiro.HealthPoint} / {guerreiro.HealthPoint}";

            hpGuerreiroBar.Maximum = guerreiro.HealthPoint;
            hpGuerreiroBar.Value = guerreiro.HealthPoint;

            hpBossBar.Maximum = Orc.HealtPoint;
            hpBossBar.Value = Orc.HealtPoint;
        }

        public void IniciarBackGroundWorker()
        {
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;

            worker.RunWorkerAsync();
        }
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var dano = Orc.Atacar();
            e.Result = dano;
        }
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var dano = Convert.ToInt32(e.Result);
            guerreiroDanoRecebidoLabel.Text = $"Dano Recebido {dano}";

            if (dano < hpGuerreiroBar.Value)
            {
                hpGuerreiroBar.Value -= dano;
            }
            else
            {
                hpGuerreiroBar.Value = 0;
            }

            hpGuerreiroLabel.Text = $"{hpGuerreiroBar.Value} / {guerreiro.HealthPoint}";

            Thread.Sleep(1000);

            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dano = guerreiro.Atacar();
            bossDanoRecebidoLabel.Text = $"Dano Recebido {dano}";

            if (dano < hpBossBar.Value)
            {
                hpBossBar.Value -= dano;
            }
            else
            {
                hpBossBar.Value = 0;
            }

            hpBossLabel.Text = $"{hpBossBar.Value} / {Orc.HealtPoint}";
            button1.Enabled = false;

            Thread.Sleep(1000);

            IniciarBackGroundWorker();
        }
    }
}
