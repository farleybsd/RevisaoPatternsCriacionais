using RevisaoPatternsCriacionais.Abstract.Factory.Designer.Interface;
using RevisaoPatternsCriacionais.Abstract.Factory.Designer.Interface.Fabrica;
using RevisaoPatternsCriacionais.Abstract.Factory.Designer.Perifericos.CriarPerifericos;

namespace RevisaoPatternsCriacionais.Abstract.Factory.Designer.Fabrica
{
    internal class EstacaoTrabalhoDesignerFactory : IEstacaoDesigner
    {
        public IPerifericoDesigner CreateEstacaoDetrabalhoDesigner()
        {
            return new EstacaoPerifericosDesigner();
        }
    }
}