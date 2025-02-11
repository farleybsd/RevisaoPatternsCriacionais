namespace RevisaoPatternsComportamental.Mediator
{
    // Mediator: Torre de Controle
    internal interface ITorreControle
    {
        void RegistrarAviao(Aviao aviao);
        void EnviarMensagem(string mensagem, Aviao aviao);
    }
}
