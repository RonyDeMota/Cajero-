using System;
using System.Collections.Generic;
using System.Text;

namespace Cajero_202010472
{
    public class SegunMod : Mod
    {
        public dynamic mods(int Mods)
        {
            int Papecien;
            int Papequini;
            if (Mods < 500)
            {
                Papecien = Mods / 100;
                Console.WriteLine($"Se le dio {Papecien} billetes de 100");
            }
            if (Mods >= 500)
            {
                if (Mods % 1000 == 0)
                {
                    Papequini = (Mods) / 500;
                    return $"Se le dio {Papequini} billetes de 500";
                }
                else
                {
                    int sob = Mods % 500;
                    Papequini = (Mods - sob) / 500;
                    Papecien = sob / 100;
                   return $"Se le dio {Papequini} billetes de 500 y {Papecien} de 100";
                }
            }
            else
            {
                return "hubo un error, reintente";
            }
        }
    }
}
