using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinoAnimal
{
    class Ave : Animal
    {
        public override void Locomove()
        {
            base.Locomove();
            Console.WriteLine("A ave voou!");
        }
        public override void Comunica()
        {
            base.Comunica();
            Console.WriteLine("A ave piou!");
        }
        public void Migra()
        {
            Console.WriteLine("A ave migrou para o sul!");
        }

    }
}
