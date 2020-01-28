using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class FactorySpells
    {
        public Spells getSpells(string spellName)
        {
            switch (spellName)
            {
                case "flame":
                    return new FlameSpell();
                case "frost":
                    return new FrostSpell();
                case "thunder":
                    return new ThunderSpell();
                default:
                    return null;
            }
        }
    }
}
