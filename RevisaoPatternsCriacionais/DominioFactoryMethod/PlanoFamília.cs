using RevisaoPatternsCriacionais.Factory.Method.Interface;

namespace RevisaoPatternsCriacionais.DominioFactoryMethod
{
    internal class PlanoFamília : IAssinaturas
    {
        public Plano NomePlano()
        {
            return new Plano("Voce acabou de Assinar o Plano Familia - Qualidade Full HD.");
        }
    }
}