namespace RevisaoPatternsEstruturais.Decorator
{
    // Componente base
    //Imagine que você está desenvolvendo um sistema para uma cafeteria onde os clientes podem personalizar suas bebidas
    internal abstract class Bebida
    {
        public abstract string ObterDescricao();
        public abstract double ObterCusto();
    }
}
