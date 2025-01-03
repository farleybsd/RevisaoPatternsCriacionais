using RevisaoPatternsEstruturais.Decorator.DecoradorBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoPatternsEstruturais.Decorator.DecoratorComplementos
{
    // Decoradores concretos
    //podem personalizar suas bebidas (café, chá, chocolate quente, etc.) com diferentes complementos como leite
    internal class Leite : BebidaDecorador
    {
        public Leite(Bebida bebida) : base(bebida){}

        public override string ObterDescricao()
        {
            return _bebida.ObterDescricao() + ", Leite";
        }
        public override double ObterCusto()
        {
            return _bebida.ObterCusto() + 0.50;
        }
    }
}
