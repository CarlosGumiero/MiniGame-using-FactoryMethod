using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class FlameSpell : Spells
    {
        public int castSpell(string magic)
        {
            switch (magic)
            {
                case "flame":
                    return -1;
                case "frost":
                    return -1;
                case "thunder":
                    return 0;
                default:
                    return 0;
            }
        }
    }
}
