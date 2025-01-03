using RevisaoPatternsEstruturais.Ponte;

namespace RevisaoPatternsEstruturais.Bridge.MeiosDeTransporte
{
    internal class Metro : Transporte
    {
        public Metro(IPlataforma plataforma) : base(plataforma)
        {
        }

        public override void EncerrarOperacao()
        {
            plataforma.Renderizar("Metrô encerrando  operação.");
        }

        public override void IniciarOperacao()
        {
            plataforma.Renderizar("Metrô iniciando operação.");
        }
    }
}
