using System;
using System.Collections.Generic;
using System.Text;

namespace Cajero_202010472
{
  public class Vainilla
    { public void Bien(int monto) {
            MenuPrin inicio = new MenuPrin();
            SacaCualto cash = new SacaCualto();
            Mod Mod;
        if (monto % 100 == 0)
            {
                if (Repositorio.Instancia.ModCash[0].forma == true)
                {
                    if (monto % 200 == 0)
                    {
                        Mod = new PrimerMod();
        Console.WriteLine(Mod.mods(monto));
                    }
                    else
                    {
                        Console.WriteLine("en este modo solo da billetes de 200 o 1000");
                        Console.WriteLine("1-Poner otro Monto\n2-Terminar Transaccion");
                        int mini = Convert.ToInt32(Console.ReadLine());

                        switch (mini)
                        {
                            case 1:
                                cash.Mony();
                                break;
                            case 2:
                                inicio.Menus();
                                break;
                            default:
                                Console.WriteLine("Esta opcion no es valida");
                                Console.ReadKey();
                                Bien(monto);
                                break;
                        }
                    }
                }
              else if (Repositorio.Instancia.ModCash[1].forma == true)
{
                    Mod = new SegunMod();
               Console.WriteLine(Mod.mods(monto));
}
 else if (Repositorio.Instancia.ModCash[2].forma == true)
{
       Mod = new TercerMod();
      Console.WriteLine(Mod.mods(monto));
}
            }
            else
{
    Console.WriteLine("EL el dinero a sacar tiene que ser tipo 100, 200 y asi");
    Console.ReadKey();
  cash.Mony();
}
        }
    }
}

