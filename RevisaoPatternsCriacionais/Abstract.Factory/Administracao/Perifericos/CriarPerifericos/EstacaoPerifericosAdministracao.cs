using RevisaoPatternsCriacionais.Abstract.Factory.Administracao.Interface;

namespace RevisaoPatternsCriacionais.Abstract.Factory.Administracao.Perifericos.CriarPerifericos
{
    internal class EstacaoPerifericosAdministracao : IPerifericosAdministracao
    {
        public MonitorAdministracao monitor()
        {
            return new MonitorAdministracao("Monitor Para Administracao Simples!");
        }

        public MouseAdministracao mouse()
        {
            return new MouseAdministracao("Mouse Para Administracao Simples!");
        }

        public TecladoAdministracao teclado()
        {
            return new TecladoAdministracao("Teclado Para Administracao Simples!");
        }
    }
}