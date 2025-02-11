namespace RevisaoPatternsComportamental.Mediator
{
    internal class Aviao
    {
        public string Nome { get; }
        private ITorreControle _torre;

        public Aviao(string nome, ITorreControle torre)
        {
            Nome = nome;
            _torre = torre;
            _torre.RegistrarAviao(this); // Registra o avião na torre
        }

        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"{Nome} enviou: {mensagem}");
            _torre.EnviarMensagem(mensagem, this);
        }

        public void ReceberMensagem(string mensagem)
        {
            Console.WriteLine($"{Nome} recebeu: {mensagem}");
        }
    }
}
