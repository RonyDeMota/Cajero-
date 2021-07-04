using System;
using System.Collections.Generic;
using System.Text;

namespace Cajero_202010472
{
    public sealed class Repositorio
    {

       

        private Repositorio()
        {
            Valor();
        }

        public void Valor()
        {
         
            FormsDis Mod1 = new FormsDis(false);
            this.ModCash.Add(Mod1);

            FormsDis Mod2 = new FormsDis(false);
            this.ModCash.Add(Mod2);

            FormsDis Mod3 = new FormsDis(false);
            this.ModCash.Add(Mod3);}
            
            public static Repositorio Instancia { get; } = new Repositorio();

        public List<FormsDis> ModCash { set; get; } = new List<FormsDis>();
        
    }
}