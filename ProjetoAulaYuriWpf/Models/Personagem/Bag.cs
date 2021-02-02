using ProjetoAulaYuriWpf.Models.Itens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAulaYuriWpf.Models.Personagem
{
    public class Bag
    {
        public List<Item> Itens { get; set; }
        public int Tamanho { get; set; }
    }
}
