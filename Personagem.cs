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
        public string Nome { get; internal set; }
        public virtual string ClassePersonagem { get; internal set; }

        private int _hp;
        private int _level = 0;

        public int Level
        {
            get
            {
                if (_level == 0)
                {
                    return 1;
                }

                return _level;
            }
            set
            {
                _level = value;
            }
        }

        public int HealthPoint
        {
            get
            {
                return _hp;
            }
            set
            {
                var consumiveis = value;

                int totais = consumiveis;

                int maxHp = 1000;

                if (_hp < maxHp)
                {
                    _hp += totais;
                }
            }
        }
        public virtual Status Status { get; set; }
        public Bag Bag { get; set; }

        public string Atacar()
        {
            return "Atacou";
        }
    }

    /// <summary>
    /// Classe Guerreiro
    /// </summary>
    public class Guerreiro : Personagem
    {
        /// <summary>
        /// Construtor Padrão
        /// </summary>
        /// <param name="nome">Nome do personagem</param>
        /// <param name="classePersonagem">Classe de combate do personagem</param>
        public Guerreiro(string nome)
        {
            this.Nome = nome;
        }

        public override string ClassePersonagem
        {
            get => base.ClassePersonagem;
            internal set => base.ClassePersonagem = "Guerreiro";
        }
        private Status _status;

        public override Status Status
        {
            get
            {
                return _status;
            }
            set
            {
                value.Strength += 5;
                _status = value;
            }
        }
    }

    /// <summary>
    /// Classe Mago
    /// </summary>
    public class Mago : Personagem
    {
        /// <summary>
        /// Construtor Padrão
        /// </summary>
        /// <param name="nome">Nome do personagem</param>
        /// <param name="classePersonagem">Classe de combate do personagem</param>
        public Mago(string nome)
        {
            this.Nome = nome;
        }

        public override string ClassePersonagem
        {
            get => base.ClassePersonagem;
            internal set => base.ClassePersonagem = "Mago";
        }

        private Status _status = null;

        public override Status Status
        {
            get // Pego a propriedade
            {
                if (_status == null)
                {
                    _status = new Status(); 
                }

                if (Level == 1)
                {
                    _status.Strength = 5;
                    _status.WillPower = 12;
                    _status.Regeneração = 1;
                }

                return _status;
            }
            set // definir a minha propriedade
            {

                value.Strength += 1;
                _status = value;
            }
        }
    }
}
