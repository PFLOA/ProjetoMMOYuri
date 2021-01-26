using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAulaYuri
{
    public class Bag
    {
        public List<Itens> Itens { get; set; }
        public int Tamanho { get; set; }
    }

    public class Itens
    {
        public virtual string Nome { get; set; }
        public virtual string Descrição { get; set; }
        public virtual string Tipo { get; set; }
        public virtual string Rank { get; set; }
        public virtual string Raridade { get; set; }
    }
}
