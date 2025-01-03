using RevisaoPatternsEstruturais.Ponte;

namespace RevisaoPatternsEstruturais.Bridge.MeiosDeTransporte
{
    internal class Bicicleta : Transporte
    {
        public Bicicleta(IPlataforma plataforma) : base(plataforma)
        {
        }

        public override void EncerrarOperacao()
        {
            plataforma.Renderizar("Bicicleta compartilhada iniciando operação.");
        }

        public override void IniciarOperacao()
        {
            plataforma.Renderizar("Bicicleta compartilhada encerrando operação.");
        }
    }
}
