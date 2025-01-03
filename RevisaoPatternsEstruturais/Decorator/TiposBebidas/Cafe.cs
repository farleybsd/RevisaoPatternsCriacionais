namespace RevisaoPatternsEstruturais.Decorator.TiposBebidas
{
    // Implementações concretas de bebidas
    //Imagine que você está desenvolvendo um sistema para uma cafeteria onde os clientes podem personalizar suas bebidas (café) 
    internal class Cafe : Bebida
    {
        public override double ObterCusto()
        {
            return 3.00;
        }

        public override string ObterDescricao()
        {
            return "Café";
        }
    }
}
