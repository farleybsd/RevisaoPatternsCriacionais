namespace RevisaoPatternsCriacionais.Abstract.Factory.Administracao.Perifericos
{
    internal class TecladoAdministracao
    {
        public string Modelo { get; set; }

        public TecladoAdministracao(string modelo)
        {
            Modelo = modelo;
        }
    }
}