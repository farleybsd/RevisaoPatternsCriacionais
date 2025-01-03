using RevisaoPatternsCriacionais.Abstract.Factory.Administracao.Perifericos;

namespace RevisaoPatternsCriacionais.Abstract.Factory.Administracao.Interface
{
    internal interface IPerifericosAdministracao
    {
        MonitorAdministracao monitor();

        MouseAdministracao mouse();

        TecladoAdministracao teclado();
    }
}