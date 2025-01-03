using RevisaoPatternsCriacionais.Abstract.Factory.Dessenvolvimento.Interface;
using RevisaoPatternsCriacionais.Abstract.Factory.Dessenvolvimento.Interface.fabrica;
using RevisaoPatternsCriacionais.Abstract.Factory.Dessenvolvimento.Perifericos.criarPerifericos;

namespace RevisaoPatternsCriacionais.Abstract.Factory.Dessenvolvimento.Fabrica
{
    internal class EstacaoTrabalhoDessenvolvimentoFactory : IEstacaoDessenvolvimentoFabrica
    {
        public IPerifericosDessenvolvimento CreateEstacaoDeDessenvolvimento()
        {
            return new EstacaoPerifericoDessenvolvimento();
        }
    }
}