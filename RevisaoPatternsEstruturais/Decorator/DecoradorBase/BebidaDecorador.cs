namespace RevisaoPatternsEstruturais.Decorator.DecoradorBase
{
    // Decorador base
    internal class BebidaDecorador : Bebida
    {
        protected Bebida _bebida;

        public BebidaDecorador(Bebida bebida)
        {
            _bebida = bebida;
        }

        public override double ObterCusto()
        {
            return _bebida.ObterCusto();
        }

        public override string ObterDescricao()
        {
            return _bebida.ObterDescricao();
        }
    }
}
