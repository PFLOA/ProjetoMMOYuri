using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAulaYuri.Personagens
{
    /// <summary>
    /// Status Personagens
    /// </summary>
    public class Status
    {
        private int _regeneração;
        private int _str;
        private int _inteligencia;

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
