namespace RevisaoPatternsEstruturais.Bridge.Plataformas
{
    internal class PlataformaMobile : IPlataforma
    {
        public void Renderizar(string mensagem)
        {
            Console.WriteLine($"[MOBILE]: {mensagem}");
        }
    }
}
