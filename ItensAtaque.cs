using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAulaYuri
{
    public class ItensAtaque : Itens
    {
        private string _nome;

        public override string Nome
        {
            get
            {
                if (string.IsNullOrEmpty(_nome))
                {
                    _nome = "Item sem nome !";
                }

                return _nome;
            }
            set => base.Nome = value;
        }

        private int _ataque;

        public int Ataque
        {
            get
            {
                return _ataque;
            }
            set
            {
                var valor = value;

                // * vezes
                // + soma/concatenar
                // - subtração
                // % resto
                // / divisão
                // () separador
                // = igual

                /* 
                  
                   valor *= 2;
                   valor += 2;
                   valor -= 2;
                   valor /= 2;

                 */

                valor *= 2;
                _ataque = valor;
            }
        }

        public string Critico { get; set; }
    }

    public class ItensDefesa : Itens
    {
        public string Defesa { get; set; }
    }
}
