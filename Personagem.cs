using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAulaYuri
{
    /// <summary>
    /// Classe publica Personagem.
    /// </summary>
    public class Personagem
    {
        /// <summary>
        /// Construtor Padrão
        /// </summary>
        /// <param name="nome">Nome do personagem</param>
        /// <param name="classePersonagem">Classe de combate do personagem</param>
        public Personagem(string nome, string classePersonagem)
        {
            this.Nome = nome;
            this.ClassePersonagem = classePersonagem;
        }

        public string Nome { get; private set; }
        public string ClassePersonagem { get; private set; }
        public Bag Bag { get; set; }

        public string Atacar()
        {
            return "Atacou";
        }
    }
}
