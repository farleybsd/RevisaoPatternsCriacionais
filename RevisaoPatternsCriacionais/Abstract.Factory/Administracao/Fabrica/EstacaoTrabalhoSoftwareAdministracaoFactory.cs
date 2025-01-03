using RevisaoPatternsCriacionais.Abstract.Factory.Administracao.Interface;
using RevisaoPatternsCriacionais.Abstract.Factory.Administracao.Interface.Fabrica;
using RevisaoPatternsCriacionais.Abstract.Factory.Administracao.Software.AdicionarSoftwares;

namespace RevisaoPatternsCriacionais.Abstract.Factory.Administracao.Fabrica
{
    internal class EstacaoTrabalhoSoftwareAdministracaoFactory : IInstalacaoSoftwareAdministracao
    {
        public ISoftwareAdministracao InstalarSoftwareAdministracao()
        {
            return new EstacaoSoftwareAdministracao();
        }
    }
}
