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
        public string Nome { get; set; }
        public string Descrição { get; set; }
        public string Tipo { get; set; }
        public string Rank { get; set; }
        public string Raridade { get; set; }
    }
}
