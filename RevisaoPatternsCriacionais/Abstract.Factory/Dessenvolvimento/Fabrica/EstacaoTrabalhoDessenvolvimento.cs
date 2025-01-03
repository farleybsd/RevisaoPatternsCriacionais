using RevisaoPatternsCriacionais.Abstract.Factory.Dessenvolvimento.Interface.fabrica;
using RevisaoPatternsCriacionais.Abstract.Factory.Dessenvolvimento.Software.Interface;
using RevisaoPatternsCriacionais.Abstract.Factory.Dessenvolvimento.Software.Interface.AdicionarSoftware;

namespace RevisaoPatternsCriacionais.Abstract.Factory.Dessenvolvimento.Fabrica
{
    internal class EstacaoTrabalhoDessenvolvimento : IInstalacaoDessenvolvimentoFactory
    {
        public IInstalacaoSoftwareDessenvolvimento InstalacaoSoftwareDessenvolvimento()
        {
            return new EstacaoDeSoftwareDessenvolvimento();
        }
    }
}
