using System;
using System.Collections.Generic;
using System.Text;

namespace Cajero_202010472
{
    public class SacaCualto
    {
        public void Mony()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Cuanto dinero quiere retirar");
                int Monto = Convert.ToInt32(Console.ReadLine());
                Vainilla Do = new Vainilla();
                Do.Bien(Monto);
            }
            catch
            {
                Console.WriteLine("Ingrese una opcion valida");
                Console.ReadKey();
                Mony();
            }

        }
    }
}
