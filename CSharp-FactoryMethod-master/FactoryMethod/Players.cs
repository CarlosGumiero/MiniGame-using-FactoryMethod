using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethod;

namespace FactoryMethod
{
    class Players : FactorySpells
    {

        public int id { get; set; }
        public int vida { get; set; }
        public string instantSpell { get; set; }

        public Players(int id, int vida, string instantSpell)
        {
            this.id = id;
            this.vida = vida;
            this.instantSpell = instantSpell;
        }

        public Spells switchSpell(int c)
        {
            switch (c)
            {
                case 1:
                    {
                        this.instantSpell = "flame";
                        return getSpells("flame");
                    }

                case 2:
                    {
                        this.instantSpell = "frost";
                        return getSpells("frost");
                    }

                case 3:
                    {
                        this.instantSpell = "thunder";
                        return getSpells("thunder");
                    }
                default: 
                    return null;
            }
        }

        public void status()
        {
            Console.WriteLine("Player " + this.id + " used " + this.instantSpell + " and now his life is " + this.vida + "." );
        }

    }
}
