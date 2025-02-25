namespace Command.Core.Interface
{
    // Interface Command que Define o Contrato para os comandos.
    internal interface ITransacao
    {
        void Execultar();
        void Desfazer();
    }
}
