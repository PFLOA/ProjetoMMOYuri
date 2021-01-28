using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAulaYuri.Bosses
{
    public class Boss
    {
        public int HealtPoint { get; set; }

        public int Atacar()
        {
            Random random = new Random();
            var num = random.Next(3);

            return 100 * num;
        }
    }
}
