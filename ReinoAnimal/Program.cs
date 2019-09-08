using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinoAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Pato DonaldDuck = new Pato( );
                Tubarão BabyShark = new Tubarão( );
                Cachorro DougDog = new Cachorro( );
                Humano Human = new Humano( 15, 48, "Tô cansado", 8, "123456789-00");
                Human.Nasce();
                Human.Cresce(3);
                Human.Amamenta();
                Human.Comunica();
                Human.Sorri();
                Human.Reproduz();
                Human.Locomove();
                Human.Morre();
                
            }
        }
    }
}
