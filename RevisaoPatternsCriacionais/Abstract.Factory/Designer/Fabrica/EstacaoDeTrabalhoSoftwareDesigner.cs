using RevisaoPatternsCriacionais.Abstract.Factory.Designer.Interface;
using RevisaoPatternsCriacionais.Abstract.Factory.Designer.Interface.Fabrica;
using RevisaoPatternsCriacionais.Abstract.Factory.Designer.Software.AdicionarSoftware;

namespace RevisaoPatternsCriacionais.Abstract.Factory.Designer.Fabrica
{
    internal class EstacaoDeTrabalhoSoftwareDesigner : IInstalacaoSoftwareFactory
    {
        public ISoftwareDesigner InstalacaoSoftwareDesinger()
        {
            return new EstacaoDeSoftware();
        }
    }
}
