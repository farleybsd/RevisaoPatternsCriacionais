namespace RevisaoPatternsCriacionais.Abstract.Factory.Administracao.Perifericos
{
    internal class MouseAdministracao
    {
        public string Modelo { get; init; }

        public MouseAdministracao(string modelo)
        {
            Modelo = modelo;
        }
    }
}