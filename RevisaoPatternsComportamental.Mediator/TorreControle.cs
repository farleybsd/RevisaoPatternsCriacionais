namespace RevisaoPatternsComportamental.Mediator
{
    // Concrete Mediator: Implementação da Torre de Controle
    internal class TorreControle : ITorreControle
    {
        private List<Aviao> _avioes = new List<Aviao>();

        public void RegistrarAviao(Aviao aviao)
        {
             _avioes.Add(aviao);
        }
        public void EnviarMensagem(string mensagem, Aviao aviao)
        {
            Console.WriteLine($"Torre de Controle recebeu mensagem de {aviao.Nome}: {mensagem}");

            // Coordena a mensagem para todos os aviões, exceto o remetente
            foreach (var a in _avioes)
            {
                if (a != aviao)
                {
                    a.ReceberMensagem(mensagem);
                }
            }
        }

       
    }
}
