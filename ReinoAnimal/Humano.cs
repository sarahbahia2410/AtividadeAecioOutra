using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinoAnimal
{
    class Humano : Mamífero
    {
        public string CPF { get; protected set; }
        public void Sorri()
        {
            
        }
        public Humano ( float idade, float peso, string som, float velocidade, string cpf)
        {
            Idade = idade;
            Som = som;
            Velocidade = velocidade;
            Peso = peso;
            CPF = cpf;

        }
    }
}
