using Command.Core.Interface;

namespace Command.Domain
{
    // Clase que gerencia e enfileira as transcoes
    internal class GerenciadorDeTransacoesBancarias
    {
        private readonly List<ITransacao> _transactionHistory = new List<ITransacao>();

        public GerenciadorDeTransacoesBancarias(List<ITransacao> transactionHistory)
        {
            _transactionHistory = transactionHistory;
        }
        public void ExecutarTransacao(ITransacao transaction)
        {
            transaction.Execultar();
            _transactionHistory.Add(transaction);
        }

        public void DesfazerTransacao(ITransacao transaction)
        {
            if (_transactionHistory.Count > 0)
            {
                var lastTransaction = _transactionHistory[^1];
                transaction.Desfazer();
                _transactionHistory.Remove(lastTransaction);
            }
        }
    }
}
