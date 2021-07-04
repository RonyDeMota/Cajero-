using System;
using System.Collections.Generic;
using System.Text;

namespace Cajero_202010472
{
    public class PrimerMod : Mod
    {
        public dynamic mods(int Mods)
        {
                int PapeDoci;
                int PapeMil;
                if (Mods < 1000)
                {
                    PapeDoci = Mods / 200;
                    return$"Se le dio {PapeDoci} billetes de 200";
                }

                if (Mods >= 1000)
                {
                    if (Mods % 1000 == 0)
                    {
                    PapeMil = (Mods) / 1000;
                    return$"Se le dio {PapeMil} billetes de 1000";
                    }
                    else
                    {
                        int sob = Mods % 1000;
                    PapeMil = (Mods - sob) / 1000;
                    PapeDoci = sob / 200;
                    return$"Se le dio {PapeMil} billetes de 1000 y {PapeDoci} de 200";
                    }
                }
                else
                {
                return "hubo un error, reintente";
            }
            }   
    }
}
