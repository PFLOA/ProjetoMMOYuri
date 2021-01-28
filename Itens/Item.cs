using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAulaYuri.Itens
{
    public class Item
    {
        public virtual string Nome { get; set; }
        public virtual string Descrição { get; set; }
        public virtual string Tipo { get; set; }
        public virtual string Rank { get; set; }
        public virtual string Raridade { get; set; }
    }

    public class ArmaPrincipal : Item
    {
        public int Dano { get; set; }
    }
}
