using RevisaoPatternsCriacionais.Factory.Method.Interface;

namespace RevisaoPatternsCriacionais.DominioFactoryMethod
{
    internal class PlanoPremium : IAssinaturas
    {
        public Plano NomePlano()
        {
            return new Plano("Voce acabou de Assinar o Plano Premium - Qualidade 4K");
        }
    }
}