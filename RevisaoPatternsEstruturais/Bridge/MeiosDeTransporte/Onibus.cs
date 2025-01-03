using RevisaoPatternsEstruturais.Ponte;

namespace RevisaoPatternsEstruturais.Bridge.MeiosDeTransporte
{
    internal class Onibus : Transporte
    {
        public Onibus(IPlataforma plataforma) : base(plataforma)
        {
        }

        public override void EncerrarOperacao()
        {
            plataforma.Renderizar("Ônibus encerrando  operação.");
        }


        public override void IniciarOperacao()
        {
            plataforma.Renderizar("Ônibus iniciando operação.");
        }

    }
}
