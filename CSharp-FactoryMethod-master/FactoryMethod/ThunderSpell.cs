using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ThunderSpell : Spells
    {
        public int castSpell(string magic)
        {
            switch (magic)
            {
                case "flame":
                    return -1;
                case "frost":
                    return 0;
                case "thunder":
                    return -1;
                default:
                    return 0;
            }
        }
    }
}
