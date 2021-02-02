using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAulaYuriWpf.Models.Itens
{

    public class Item : INotifyPropertyChanged
    {
        private string _imageUrl;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Descrição { get; set; }
        public virtual string Tipo { get { return this.GetType().Name; } }
        public virtual string Rank { get; set; }
        public virtual string Raridade { get; set; }
        public virtual string ImageUrl
        {
            get
            {
                return _imageUrl;
            }
            set
            {
                _imageUrl = value;
                OnPropertyChanged();
            }
        }
    }

    public class ItemArmaPrincipal : Item
    {
        public int Dano { get; set; }
    }
    public class ItemArmaSecundaria : Item
    {
        public int Dano { get; set; }
    }
    public class ItemArmadura : Item
    {
        public int Dano { get; set; }
    }
    public class ItemElmo : Item
    {
        public int Dano { get; set; }
    }
    public class ItemBota : Item
    {
        public int Dano { get; set; }
    }
    public class ItemLuva : Item
    {
        public int Dano { get; set; }
    }
    public class ItemCinto : Item
    {
        public int Dano { get; set; }
    }
    public class ItemColar : Item
    {
        public int Dano { get; set; }
    }
    public class ItemAnel : Item
    {
        public int Dano { get; set; }
    }
    public class ItemBrinco : Item
    {
        public int Dano { get; set; }
    }

    public class ItemConsumivel : Item
    {
        public TimeSpan CoolDown { get; set; }
        public string ExtraEffect { get; set; }

        //método consumir
    }
    public class ItemConsumivelHealthPotion : ItemConsumivel
    {
        public int Recover { get; set; }
        public override string ImageUrl { get => base.ImageUrl; set => base.ImageUrl = value; }
    }

}
