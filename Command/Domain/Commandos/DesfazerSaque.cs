using Command.Core.Interface;

namespace Command.Domain.Commandos
{
    // Classe concreta para operacao de depositos Que foi Definida Na Classe ContaBancaria
    internal class DesfazerSaque : ITransacao
    {
        private readonly ContaBancaria _contaBancaria;

        private readonly decimal _quantidade;
        public DesfazerSaque(ContaBancaria contaBancaria, decimal quantidade)
        {
            _contaBancaria = contaBancaria;
            _quantidade = quantidade;
        }

        public void Desfazer()
        {
            _contaBancaria.Depositar(_quantidade);
        }

        public void Execultar()
        {
            _contaBancaria.DesfazerSaque(_quantidade); ;
        }
    }
}
