namespace RevisaoPatternsEstruturais.Bridge.Plataformas
{
    // Implementações Concretas de Plataforma
    internal class PlataformaWeb : IPlataforma
    {
        public void Renderizar(string mensagem)
        {
            Console.WriteLine($"[WEB]: {mensagem}");
        }
    }
}
