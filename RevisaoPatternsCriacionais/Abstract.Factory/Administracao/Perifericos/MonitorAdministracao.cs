namespace RevisaoPatternsCriacionais.Abstract.Factory.Administracao.Perifericos
{
    internal class MonitorAdministracao
    {
        public string Modelo { get; init; }

        public MonitorAdministracao(string modelo)
        {
            Modelo = modelo;
        }
    }
}