using System;
using System.Collections.Generic;
using System.Text;

namespace Cajero_202010472 
{
    public class MenuPrin : MENUSS
    {
        public void Menus()
        {
            try
            {
                MenuRet Dispen = new MenuRet();
                SacaCualto Cash = new SacaCualto();
                Console.Clear();
                Console.WriteLine("1-Modo de dispensación\n2-Retiro de Dinero\n3-Salir");
                int o = Convert.ToInt32(Console.ReadLine());
                switch (o)
                {
                    case (int)Opcionesenum.Dispensacion:
                        Dispen.Menus();
                        Console.ReadKey();
                        Menus();
                        break;
                    case (int)Opcionesenum.Retiro:
                        Cash.Mony();
                        Console.ReadKey();
                        Menus();
                        break;
                    case (int)Opcionesenum.Salir:
                        Console.WriteLine("Gracias Por Usar Mi Cajero Automatico");
                        Console.ReadKey();
                        Environment.Exit(0);
                       break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        Menus();
                        return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ingrese una opcion valida");
                Menus();
                throw;
            }
        }
    }
}
