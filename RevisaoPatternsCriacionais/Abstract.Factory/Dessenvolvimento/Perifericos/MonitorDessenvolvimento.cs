namespace RevisaoPatternsCriacionais.Abstract.Factory.Dessenvolvimento.Perifericos
{
    internal class MonitorDessenvolvimento
    {
        public string Modelo { get; init; }

        public MonitorDessenvolvimento(string modelo)
        {
            Modelo = modelo;
        }
    }
}