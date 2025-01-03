namespace RevisaoPatternsCriacionais.Abstract.Factory.Dessenvolvimento.Software.Interface.AdicionarSoftware
{
    internal class EstacaoDeSoftwareDessenvolvimento : IInstalacaoSoftwareDessenvolvimento
    {
        public Git Git()
        {
            return new Git("Git Hub Desktop");
        }

        public VisualStudio VisualStudio()
        {
            return new VisualStudio("Visual Studio 2022 Commnunity");
        }
    }
}
