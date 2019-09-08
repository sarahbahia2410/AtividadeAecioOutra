using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinoAnimal
{
    class Peixe : Animal
    {
        public string Barbatanas { get; protected set; }
        public override void Locomove()
        {
            base.Locomove();
            Console.WriteLine("O peixe nadou!");
        }
        
    }
}
