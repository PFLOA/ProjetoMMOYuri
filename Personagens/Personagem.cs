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

        int _hp;
        int _level = 0;
        Status _status; 
        Gears _gears;

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
        public Gears Gear
        {
            get
            {
                return _gears;
            }
            set
            {
                _gears = value;
            }
        }
        public virtual Status Status
        {
            get
            {
                if (_status == null)
                {
                    _status = new Status();
                }

                return _status;
            }
            set
            {
                _status = value;
            }
        }
        public Bag Bag { get; set; }

        /// <summary>
        /// Ataca NPC, Fórmula: 2 * armaStatus + 2 * Status.Strenght.
        /// </summary>
        /// <returns>Dano causado.</returns>
        public int Atacar()
        {
            Random random = new Random();
            var num = random.Next(3);

            return ((2 * Gear.ArmaPrincipal.Dano) + (2 * Status.Strength)) * num;
        }
    }

    /// <summary>
    /// Classe Guerreiro
    /// </summary>
    public class Guerreiro : Personagem // classe base.
    {
        /// <summary>
        /// Construtor Padrão
        /// </summary>
        /// <param name="nome">Nome do personagem</param>
        public Guerreiro(string nome)
        {
            this.Nome = nome;
        }

        public override string ClassePersonagem
        {
            get => base.ClassePersonagem;
            internal set => base.ClassePersonagem = "Guerreiro";
        }

        public override Status Status
        {
            get
            {
                if (Level == 1)
                {
                    base.Status.Strength = 5;
                    base.Status.WillPower = 12;
                    base.Status.Regeneração = 1;
                    base.Status.Inteligencia = 8;
                }

                return base.Status;
            }
            set
            {
                value.Strength += 5;
                base.Status = value;
            }
        }
    }

    /// <summary>
    /// Classe Mago
    /// </summary>
    public class Mago : Personagem // Herança
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

        public override Status Status
        {
            get // Pego a propriedade
            {
                if (Level == 1)
                {
                    base.Status.Strength = 5;
                    base.Status.WillPower = 12;
                    base.Status.Regeneração = 1;
                    base.Status.Inteligencia = 12;
                }

                return base.Status;
            }
            set // definir a minha propriedade
            {

                value.Strength += 1;
                base.Status = value;
            }
        }
    }

    /// <summary>
    /// Classe Necromante
    /// </summary>
    public class Necromante : Personagem
    {
        public Necromante(string nome)
        {
            this.Nome = nome;
        }

        /// <summary>
        /// Status Necromante
        /// </summary>
        public override Status Status
        {
            get
            {
                if (Level == 1)
                {
                    base.Status.Strength = 5;
                    base.Status.WillPower = 12;
                    base.Status.Regeneração = 3;
                    base.Status.Inteligencia = 12;
                }

                return base.Status;
            }
            set => base.Status = value;
        }
    }
}
