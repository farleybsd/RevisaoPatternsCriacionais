namespace Command.Domain
{
    internal class ContaBancaria
    {
        public string TitularDaConta { get;  }
        public decimal Saldo { get; private set; }
        public ContaBancaria(string titularDaConta, decimal saldo)
        {
            TitularDaConta = titularDaConta;
            Saldo = saldo;
        }
       
        public void Depositar(decimal quantidade)
        {
            Saldo += quantidade;
            Console.WriteLine($"Depositado a {quantidade} realizado. Saldo Atual: {Saldo}");
        } 
        
        public void DesfazerSaque(decimal quantidade)
        {
            if(Saldo >-quantidade)
            {
                Saldo -= quantidade;
                Console.WriteLine($"O Saque {quantidade} realizado. Saldo Atual: {Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente para realizar o saque");
            }
        }
    }
}
