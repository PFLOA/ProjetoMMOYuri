using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAulaYuriWpf.Models.Personagem
{
    public class Status
    {
        private int _regeneração;
        private int _str;
        private int _inteligencia;

        public string imgInteligencia { get { return @"F:\workspace\ProjetoAulaYuriWpf\bin\Debug\img\inteligence.png"; } }
        public string imgRegen { get { return @"F:\workspace\ProjetoAulaYuriWpf\bin\Debug\img\recovery.png"; } }
        public string imgStr { get { return @"F:\workspace\ProjetoAulaYuriWpf\bin\Debug\img\strength.png"; } }
        public string imgWillpower { get { return @"F:\workspace\ProjetoAulaYuriWpf\bin\Debug\img\willpower.png"; } }

        public int Regeneração
        {
            get
            {
                return _regeneração;
            }
            set
            {
                _regeneração = value;
            }
        }

        public int Strength
        {
            get
            {
                return _str;
            }
            set
            {
                _str = value;
            }
        }

        /// <summary>
        /// Força de Vontade.
        /// </summary>
        public int WillPower { get; set; }

        public int Inteligencia
        {
            get
            {
                return _inteligencia;
            }
            set
            {
                _inteligencia = value;
            }
        }

        public int Resistencia { get; internal set; }
    }
}
