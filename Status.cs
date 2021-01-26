using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAulaYuri
{
    public class Status
    {
        private int _regeneração; 
        private int _str;

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
        public int WillPower { get; set; }
    }
}
