using RevisaoPatternsCriacionais.Abstract.Factory.Administracao.Interface;

namespace RevisaoPatternsCriacionais.Abstract.Factory.Administracao.Software.AdicionarSoftwares
{
    internal class EstacaoSoftwareAdministracao : ISoftwareAdministracao
    {
        public MicrosoftOffice MicrosoftOffice()
        {
            return new MicrosoftOffice("Microsoft Office 2025");
        }

        public SistemaErp SistemaErp()
        {
            return new SistemaErp("Prometheus");
        }
    }
}
