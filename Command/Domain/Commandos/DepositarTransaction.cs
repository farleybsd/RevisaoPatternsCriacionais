using Command.Core.Interface;

namespace Command.Domain.Commandos
{
    // Classe concreta para operacao de depositos Que foi Definida Na Classe ContaBancaria
    internal class DepositarTransaction : ITransacao
    {
        private readonly ContaBancaria _contaBancaria;

        private readonly decimal _quantidade;
        public DepositarTransaction(ContaBancaria contaBancaria, decimal quantidade)
        {
            _contaBancaria = contaBancaria;
            _quantidade = quantidade;
        }

        public void Desfazer()
        {
            _contaBancaria.DesfazerSaque(_quantidade);
        }

        public void Execultar()
        {
            _contaBancaria.Depositar(_quantidade);
        }
    }
}
