using System;
using System.Collections.Generic;
using System.Text;

namespace Cajero_202010472
{
    public class MenuRet : MENUSS
    {
        public void Menus() {
            try
            { 
                var forma1 = Repositorio.Instancia.ModCash[0].forma;
                var forma2 = Repositorio.Instancia.ModCash[1].forma;
                var forma3 = Repositorio.Instancia.ModCash[2].forma;
      

               
                MenuPrin Menu = new MenuPrin();
                Console.Clear();
                Console.WriteLine("1-Billetes de 200 y 1000\n2-Billetes de 100 y 500\n3-Modo eficiente: billetes de 100, 200, 500 y 1000\n4-Volver");
                int i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case (int)Opcionesenum.PrimerMod:
                        Repositorio.Instancia.ModCash[0].forma = true;
                        Repositorio.Instancia.ModCash[1].forma = false;
                        Repositorio.Instancia.ModCash[2].forma = false;   
                        Menu.Menus();
                        break;
                    case (int)Opcionesenum.SegunMod:
                        Repositorio.Instancia.ModCash[0].forma = false;
                        Repositorio.Instancia.ModCash[1].forma = true;
                        Repositorio.Instancia.ModCash[2].forma = false;
                        Menu.Menus();
                        break;
                    case (int)Opcionesenum.TercerMod:
                        Repositorio.Instancia.ModCash[0].forma = false;
                        Repositorio.Instancia.ModCash[1].forma = false;
                        Repositorio.Instancia.ModCash[2].forma = true;
                        Console.ReadKey();
                        Menu.Menus();
                        break;
                    case (int)Opcionesenum.volver:
                        Menu.Menus();
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
