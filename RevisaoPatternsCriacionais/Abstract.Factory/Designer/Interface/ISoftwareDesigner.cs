using RevisaoPatternsCriacionais.Abstract.Factory.Designer.Software;

namespace RevisaoPatternsCriacionais.Abstract.Factory.Designer.Interface
{
    internal interface ISoftwareDesigner
    {
        Ilustrator Ilustrator();
        PhotoShop PhotoShop();
    }
}
