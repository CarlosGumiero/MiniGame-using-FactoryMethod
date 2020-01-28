using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class FrostSpell : Spells
    {
        public int castSpell(string magic)
        {
            switch (magic)
            {
                case "flame":
                    return 0;
                case "frost":
                    return -1;
                case "thunder":
                    return -1;
                default:
                    return 0;
            }
        }
    }
}
