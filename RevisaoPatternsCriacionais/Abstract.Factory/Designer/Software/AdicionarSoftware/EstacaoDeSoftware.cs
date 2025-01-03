using RevisaoPatternsCriacionais.Abstract.Factory.Designer.Interface;

namespace RevisaoPatternsCriacionais.Abstract.Factory.Designer.Software.AdicionarSoftware
{
    internal class EstacaoDeSoftware : ISoftwareDesigner
    {
        public Ilustrator Ilustrator()
        {
            return new Ilustrator("Ilustrator Versao 15");
        }

        public PhotoShop PhotoShop()
        {
            return new PhotoShop("PhotoShop Versao 22");
        }
    }
}
