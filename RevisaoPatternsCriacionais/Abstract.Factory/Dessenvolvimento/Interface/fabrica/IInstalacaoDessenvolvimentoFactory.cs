using RevisaoPatternsCriacionais.Abstract.Factory.Dessenvolvimento.Software.Interface;

namespace RevisaoPatternsCriacionais.Abstract.Factory.Dessenvolvimento.Interface.fabrica
{
    internal interface IInstalacaoDessenvolvimentoFactory
    {
        IInstalacaoSoftwareDessenvolvimento InstalacaoSoftwareDessenvolvimento();
    }
}
