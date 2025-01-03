using RevisaoPatternsCriacionais.Abstract.Factory.Designer.Interface;

namespace RevisaoPatternsCriacionais.Abstract.Factory.Designer.Perifericos.CriarPerifericos
{
    internal class EstacaoPerifericosDesigner : IPerifericoDesigner
    {
        public MonitorDesigner monitor()
        {
            return new MonitorDesigner("Monitor Ultra Wide 4k para o Designer");
        }

        public MouseDesigner mouse()
        {
            return new MouseDesigner("Mouse Ergonomico para o Designer");
        }

        public TecladoDesigner teclado()
        {
            return new TecladoDesigner("Teclado Ergonomico para o Designer");
        }
    }
}