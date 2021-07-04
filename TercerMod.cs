using System;
using System.Collections.Generic;
using System.Text;

namespace Cajero_202010472
{
    public class TercerMod : Mod
    {
        public dynamic mods(int Mods)
        {
           
                try
                {
                    if (Mods == 1000 || Mods == 500 || Mods == 200 || Mods == 100)
                    {
                        return $"Se le dio 1 billete de {Mods}";
                    }

                    int papemil = Mods % 1000;
                    int papequini = papemil % 500;
                    int papedoci = papequini % 200;
                    int papecien = papedoci % 100;

                  int BiMil = (Mods - papemil) / 1000;
                int BiQuini = (papemil - papequini) / 500;
                int BiDoci = (papequini - papedoci) / 200;
                int BiCien = (papedoci - papecien) / 100;

                    if (Mods % 1000 == 0)
                    {
                    BiMil = (Mods) / 1000;
                        return $"Se le dio {BiMil} billetes de 1000";
                    }
                string tex = "te dio ";
                if (BiMil != 0)
                    {
               //tex tiene un pequeño texto a imprimir, me daba error al hacerlo con el WriteLine
                    tex += $"{BiMil} billete de 1000";
                    }
                    if (BiQuini != 0)
                    {
                        if (BiMil != 0)
                        {
                        tex += $", {BiQuini} billete de 500";
                        }
                        else
                        {
                        tex += $"{BiQuini} billete de 500";
                        }
                    }
                    if (BiDoci != 0)
                    {
                        if (BiMil != 0 || BiQuini != 0)
                        {
                        tex += $", {BiDoci} billete de 200";
                        }
                        else
                        {
                        tex += $"{BiDoci} billete de 200";
                        }
                    }
                    if (BiCien != 0)
                    {
                    tex += $" y {BiCien} billete de 100.";
                    }
                    return tex;
                }
                catch
                {
                return "hubo un error, reintente";
            }

            }
        }
    }

