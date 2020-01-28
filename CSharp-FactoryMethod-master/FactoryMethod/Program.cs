using System;
using FactoryMethod;
using System.Collections.Generic;

namespace FactoryMethod
{
    /* 
    Este programa foi feito para aprender o conceito da pattern Factory Method, utilizando uma Factory para as spells e
    após instanciar algumas informações de uma classe de Players, uma IA executa uma sequencia de códigos onde determinará
    qual dos dois players será o vencedor.
    */ 
    class Program
    {
        static void Main(string[] args)
        {
            Spells chosenSpell1, chosenSpell2;
            FactorySpells facSpell = new FactorySpells();

            var rand = new Random();

            Players p1 = new Players(1, 10, "");
            Players p2 = new Players(2, 10, "");

            while (p1.vida > 0 && p2.vida > 0)
            {
                // Instancia as as spells da interface Spells de cada player com um número random de 1 a 3.
                    chosenSpell1 = p1.switchSpell(rand.Next(1, 4));
                    chosenSpell2 = p2.switchSpell(rand.Next(1, 4));

                // Adiciona ou remove a vida de cada jogador através de uma comparação dentro da spell selecionada da interface Spells. 
                //Ex: se a chosenSpell1 for "flame" e a instantspell do p2 for "frost", será retornado o valor -1, diminuindo na vida do p1.
                    p1.vida += chosenSpell1.castSpell(p2.instantSpell);
                    p2.vida += chosenSpell2.castSpell(p1.instantSpell);

                //Imprime as informações de ambos jogadores cada turno.
                    p1.status();
                    p2.status();
                    Console.WriteLine();
            }

                //Mostra qual dos jogadores será o vencedor.
            if(p1.vida > p2.vida)
            {
                Console.WriteLine("Player " + p1.id + " wins!");
            }
            else if (p1.vida < p2.vida)
            {
                Console.WriteLine("Player " + p2.id + " wins!");
            }
            else
            {
                Console.WriteLine("Both players died!");
            }
        }
    }
}
