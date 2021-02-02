using ProjetoAulaYuriWpf.Models.Itens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAulaYuriWpf.Models.Personagem
{
    public class Gears 
    {
        public ItemArmaPrincipal ArmaPrincipal { get; set; }
        public ItemArmaSecundaria ArmaSecundaria { get; set; }
        public ItemConsumivelHealthPotion ConsumivelHP { get; set; }
    }
}
