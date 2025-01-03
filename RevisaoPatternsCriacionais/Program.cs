using RevisaoPatternsCriacionais.Abstract.Factory.Administracao.Fabrica;
using RevisaoPatternsCriacionais.Abstract.Factory.Administracao.Interface.Fabrica;
using RevisaoPatternsCriacionais.Abstract.Factory.Designer.Fabrica;
using RevisaoPatternsCriacionais.Abstract.Factory.Designer.Interface.Fabrica;
using RevisaoPatternsCriacionais.Abstract.Factory.Dessenvolvimento.Fabrica;
using RevisaoPatternsCriacionais.Abstract.Factory.Dessenvolvimento.Interface.fabrica;
using RevisaoPatternsCriacionais.Abstract.Factory.Dessenvolvimento.Perifericos.criarPerifericos;
using RevisaoPatternsCriacionais.Factory.Method._3.FabricaConcreta;
using RevisaoPatternsCriacionais.Factory.Method.Fabrica;
using RevisaoPatternsCriacionais.FluentBuilder.Dominio;
using System;

Console.WriteLine("###########FactoryMethod############");

Console.WriteLine("App: Plano Básico.");
FabricaDePlano(new FabricaPlanoBasico());

Console.WriteLine("App: Plano Premiun.");
FabricaDePlano(new FabricaPlanoPremium());

Console.WriteLine("App: Plano Familia.");
FabricaDePlano(new FabricaPlanoFamília());
Console.WriteLine("###########FactoryMethod############");

Console.WriteLine("###########AbstractFactory############");

Console.WriteLine("As estações de trabalho: - Administracao");
EstacaoDeTrabalhoAdministracao(new EstacaoTrabalhoAdministracaoFactory());

Console.WriteLine("As estações de trabalho: - Designer");
EstacaoDeTrabalhoDesigner(new EstacaoTrabalhoDesignerFactory());

Console.WriteLine("As estações de trabalho: - Dessenvolvimento");
EstacaoDeTrabalhoDessenvolvimento(new EstacaoTrabalhoDessenvolvimentoFactory());

Console.WriteLine("As estações de trabalho: - Administracao- Software");
EstacaoDeTrabalhoAdministracaoSoftware(new EstacaoTrabalhoSoftwareAdministracaoFactory());

Console.WriteLine("As estações de trabalho: - Dessenvolvimento- Software");
EstacaoDeTrabalhoDessenvolvimentoSoftware(new EstacaoTrabalhoDessenvolvimento());

Console.WriteLine("As estações de trabalho: - Designer - Software");
EstacaoDeTrabalhoDesigneroftware(new EstacaoDeTrabalhoSoftwareDesigner());


Console.WriteLine("###########AbstractFactory############");


Console.WriteLine("###########FluentBuilder############");
var car = new Car.Builder()
                 .setMake("Gol")
                 .setModel("VW")
                 .setYear(2025)
                 .setColor("red")
                 .build();
Console.WriteLine(car.ToString());
Console.WriteLine("###########FluentBuilder############");


void FabricaDePlano(FabricaDePlanos fabricaDePlanos)
{
    var assinatura = fabricaDePlanos.FactoryMethod();
    var plano = assinatura.NomePlano();
    Console.WriteLine($"Seu Plano Atual é: {plano.NomePlano}");
}

void EstacaoDeTrabalhoAdministracao(IEstacaoDeTrabalhoAdministracao factory)
{
    var estacaodeTrabalhoAdministracao = factory.CreateEstacaoDetrabalhoDAdministracao();
    Console.WriteLine($"Montior Modelo:{estacaodeTrabalhoAdministracao.monitor().Modelo}");
    Console.WriteLine($"Mouse Modelo:{estacaodeTrabalhoAdministracao.mouse().Modelo}");
    Console.WriteLine($"Mouse Modelo:{estacaodeTrabalhoAdministracao.teclado().Modelo}");
}

void EstacaoDeTrabalhoDesigner(IEstacaoDesigner factory)
{
    var estacaodeTrabalhoAdministracao = factory.CreateEstacaoDetrabalhoDesigner();
    Console.WriteLine($"Montior Modelo:{estacaodeTrabalhoAdministracao.monitor().Modelo}");
    Console.WriteLine($"Mouse Modelo:{estacaodeTrabalhoAdministracao.mouse().Modelo}");
    Console.WriteLine($"Mouse Modelo:{estacaodeTrabalhoAdministracao.teclado().Modelo}");
}

void EstacaoDeTrabalhoDessenvolvimento(IEstacaoDessenvolvimentoFabrica factory)
{
    var estacaodeTrabalhoAdministracao = factory.CreateEstacaoDeDessenvolvimento();
    Console.WriteLine($"Montior Modelo:{estacaodeTrabalhoAdministracao.monitor().Modelo}");
    Console.WriteLine($"Mouse Modelo:{estacaodeTrabalhoAdministracao.mouse().Modelo}");
    Console.WriteLine($"Mouse Modelo:{estacaodeTrabalhoAdministracao.teclado().Modelo}");
}

void EstacaoDeTrabalhoAdministracaoSoftware(IInstalacaoSoftwareAdministracao factory)
{
    var estacaodeTrabalhoAdministracao = factory.InstalarSoftwareAdministracao();
    Console.WriteLine(estacaodeTrabalhoAdministracao.MicrosoftOffice().Nome);
    Console.WriteLine(estacaodeTrabalhoAdministracao.SistemaErp().Nome);
}

void EstacaoDeTrabalhoDessenvolvimentoSoftware(IInstalacaoDessenvolvimentoFactory factory)
{
    var estacaodeTrabalhoAdministracao = factory.InstalacaoSoftwareDessenvolvimento();
    Console.WriteLine(estacaodeTrabalhoAdministracao.Git().Nome);
    Console.WriteLine(estacaodeTrabalhoAdministracao.VisualStudio().Nome);
}

void EstacaoDeTrabalhoDesigneroftware(IInstalacaoSoftwareFactory factory)
{
    var estacaodeTrabalhoAdministracao = factory.InstalacaoSoftwareDesinger();
    Console.WriteLine(estacaodeTrabalhoAdministracao.Ilustrator().Nome);
    Console.WriteLine(estacaodeTrabalhoAdministracao.PhotoShop().Nome);
}