using RevisaoPatternsCriacionais.Abstract.Factory.Administracao.Interface;
using RevisaoPatternsCriacionais.Abstract.Factory.Administracao.Interface.Fabrica;
using RevisaoPatternsCriacionais.Abstract.Factory.Administracao.Perifericos.CriarPerifericos;

namespace RevisaoPatternsCriacionais.Abstract.Factory.Administracao.Fabrica
{
    internal class EstacaoTrabalhoAdministracaoFactory : IEstacaoDeTrabalhoAdministracao
    {
        public IPerifericosAdministracao CreateEstacaoDetrabalhoDAdministracao()
        {
            return new EstacaoPerifericosAdministracao();
        }
    }
}