// Cria uma conta bancária com saldo inicial de 1000
using Command.Core.Interface;
using Command.Domain.Commandos;
using Command.Domain;

ContaBancaria conta = new ContaBancaria("João", 1000);
Console.WriteLine($"Conta de {conta.TitularDaConta} criada com saldo: {conta.Saldo}");

// Inicializa o gerenciador de transações com uma lista vazia
var transactionHistory = new List<ITransacao>();
GerenciadorDeTransacoesBancarias gerenciador = new GerenciadorDeTransacoesBancarias(transactionHistory);

// Executa uma transação de depósito de 500
ITransacao depositar = new DepositarTransaction(conta, 500);
gerenciador.ExecutarTransacao(depositar);
// Neste ponto, o saldo deverá ser atualizado para 1500

// Desfaz a última transação (o depósito)
gerenciador.DesfazerTransacao(depositar);
// O saldo retorna para 1000

// Exemplo adicional: Executando uma transação de "saque" (utilizando a classe DesfazerSaque)
ITransacao saque = new DesfazerSaque(conta, 200);
gerenciador.ExecutarTransacao(saque);
// Aqui, o método Execultar() de DesfazerSaque chama o método DesfazerSaque da conta,
// realizando a operação de retirada (sujeita à lógica implementada na classe ContaBancaria)

// Em seguida, desfaz a transação do saque
gerenciador.DesfazerTransacao(saque);
// Assim, o saldo volta ao valor anterior à execução do saque

Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();