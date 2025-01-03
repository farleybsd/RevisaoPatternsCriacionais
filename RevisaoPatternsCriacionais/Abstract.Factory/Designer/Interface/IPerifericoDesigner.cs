using RevisaoPatternsCriacionais.Abstract.Factory.Designer.Perifericos;

namespace RevisaoPatternsCriacionais.Abstract.Factory.Designer.Interface
{
    internal interface IPerifericoDesigner
    {
        MonitorDesigner monitor();

        MouseDesigner mouse();

        TecladoDesigner teclado();
    }
}