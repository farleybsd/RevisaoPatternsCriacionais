using RevisaoPatternsEstruturais.Decorator.DecoradorBase;

namespace RevisaoPatternsEstruturais.Decorator.DecoratorComplementos
{
    // Decoradores concretos
    // podem personalizar suas bebidas (café, chá, chocolate quente, etc.) com diferentes complementos como Chantilly.
    internal class Chantilly : BebidaDecorador
    {
        public Chantilly(Bebida bebida) : base(bebida){}

        public override string ObterDescricao()
        {
            return _bebida.ObterDescricao() + ", Chantilly";
        }

        public override double ObterCusto()
        {
            return _bebida.ObterCusto() + 1.00;
        }
    }
}
