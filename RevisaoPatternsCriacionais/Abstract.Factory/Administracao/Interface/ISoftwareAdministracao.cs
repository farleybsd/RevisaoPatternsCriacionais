using RevisaoPatternsCriacionais.Abstract.Factory.Administracao.Software;

namespace RevisaoPatternsCriacionais.Abstract.Factory.Administracao.Interface
{
    internal interface ISoftwareAdministracao
    {
        MicrosoftOffice MicrosoftOffice();
        SistemaErp SistemaErp();
    }
}
