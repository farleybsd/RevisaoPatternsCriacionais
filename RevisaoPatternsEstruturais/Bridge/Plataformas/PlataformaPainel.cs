namespace RevisaoPatternsEstruturais.Bridge.Plataformas
{
    internal class PlataformaPainel : IPlataforma
    {
        public void Renderizar(string mensagem)
        {
            Console.WriteLine($"[PAINEL]: {mensagem}");
        }
    }
}
