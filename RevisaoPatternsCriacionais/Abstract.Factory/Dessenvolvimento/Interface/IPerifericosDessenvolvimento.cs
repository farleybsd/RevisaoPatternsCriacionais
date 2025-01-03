using RevisaoPatternsCriacionais.Abstract.Factory.Dessenvolvimento.Perifericos;

namespace RevisaoPatternsCriacionais.Abstract.Factory.Dessenvolvimento.Interface
{
    internal interface IPerifericosDessenvolvimento
    {
        MonitorDessenvolvimento monitor();

        MouseDessenvolvimento mouse();

        TecladoDessenvolvimento teclado();
    }
}