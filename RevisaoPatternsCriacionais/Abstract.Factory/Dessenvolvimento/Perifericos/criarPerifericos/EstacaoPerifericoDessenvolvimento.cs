using RevisaoPatternsCriacionais.Abstract.Factory.Dessenvolvimento.Interface;

namespace RevisaoPatternsCriacionais.Abstract.Factory.Dessenvolvimento.Perifericos.criarPerifericos
{
    internal class EstacaoPerifericoDessenvolvimento : IPerifericosDessenvolvimento
    {
        public MonitorDessenvolvimento monitor()
        {
            return new MonitorDessenvolvimento("Monitor Dessenvolvimento ultra Wide 4k IPS");
        }

        public MouseDessenvolvimento mouse()
        {
            return new MouseDessenvolvimento("Mouse Ergonomico Dessenvolvimento");
        }

        public TecladoDessenvolvimento teclado()
        {
            return new TecladoDessenvolvimento("Teclado  Ergonomico Dessenvolvimento");
        }
    }
}