using RevisaoPatternsCriacionais.Factory.Method.Interface;

namespace RevisaoPatternsCriacionais.DominioFactoryMethod
{
    internal class PlanoBasico : IAssinaturas
    {
        public Plano NomePlano()
        {
            return new Plano("Voce acabou de Assinar o Plano Basico -Qualidade HD ");
        }
    }
}