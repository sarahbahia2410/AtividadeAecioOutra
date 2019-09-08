using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinoAnimal
{
    class Mamífero : Animal
    {
        public override void Locomove()
        {
            base.Locomove();
            Console.WriteLine("O mamífero andou ");
        }
        public void Amamenta ()
        {
            Console.WriteLine("O mamífero amamentou");
        }
        public override void Comunica()
        {
            base.Comunica();
            Console.WriteLine("O mamífero emitiu som");
        }
    }
}
