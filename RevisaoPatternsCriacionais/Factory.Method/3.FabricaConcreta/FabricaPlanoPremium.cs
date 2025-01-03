using RevisaoPatternsCriacionais.DominioFactoryMethod;
using RevisaoPatternsCriacionais.Factory.Method.Fabrica;
using RevisaoPatternsCriacionais.Factory.Method.Interface;

namespace RevisaoPatternsCriacionais.Factory.Method._3.FabricaConcreta
{
    internal class FabricaPlanoPremium : FabricaDePlanos
    {
        public override IAssinaturas FactoryMethod()
        {
            return new PlanoPremium();
        }
    }
}