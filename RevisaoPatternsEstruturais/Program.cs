// #### Adapter ###
using RevisaoPatternsEstruturais.Adapter;
using RevisaoPatternsEstruturais.Bridge;
using RevisaoPatternsEstruturais.Bridge.MeiosDeTransporte;
using RevisaoPatternsEstruturais.Bridge.Plataformas;
using RevisaoPatternsEstruturais.Composite.Composite;
using RevisaoPatternsEstruturais.Composite.TiposDeArquivos;
using RevisaoPatternsEstruturais.Decorator.DecoratorComplementos;
using RevisaoPatternsEstruturais.Decorator.TiposBebidas;
using RevisaoPatternsEstruturais.Decorator;
using RevisaoPatternsEstruturais.Ponte;

UsuarioRequest usuario = new() {Nome = "Farley",Idade=32,Email="teste@teste.com" };
IUsuarioAdapter usuarioAdapter = new UsuarioAdapter();
var usuarioCommandCreate = usuarioAdapter.Adapt(usuario);

// #### Fim, Adapter ###

// #### Bridge
// Criando plataformas
IPlataforma web = new PlataformaWeb();
IPlataforma mobile = new PlataformaMobile();
IPlataforma Painel = new PlataformaPainel();

// Criando transportes com plataformas
Transporte onibusWeb = new Onibus(web);
Transporte metroMobile = new Metro(mobile);
Transporte bicicletaPainel = new Bicicleta(Painel);

// Operando os transportes
onibusWeb.IniciarOperacao();
onibusWeb.EncerrarOperacao();

metroMobile.IniciarOperacao();
metroMobile.EncerrarOperacao();

bicicletaPainel.IniciarOperacao();
bicicletaPainel.EncerrarOperacao();
// #### Fim Bridge ###

// # Composite 
// Criando arquivos e pastas
var file1 = new RevisaoPatternsEstruturais.Composite.TiposDeArquivos.File("logo.png", 2);
var file2 = new RevisaoPatternsEstruturais.Composite.TiposDeArquivos.File("briefing.docx", 1);
var file3 = new RevisaoPatternsEstruturais.Composite.TiposDeArquivos.File("inspiracao.jpg", 3);

var subFolder = new Folder("Referências");
subFolder.Add(file3);

var mainFolder = new Folder("Projeto A");
mainFolder.Add(file1);
mainFolder.Add(file2);
mainFolder.Add(subFolder);

// Exibindo estrutura
Console.WriteLine("Estrutura original:");
mainFolder.Display();

// Calculando tamanho total
Console.WriteLine($"\nTamanho total: {mainFolder.GetSize()} MB");

// Duplicando a estrutura
var duplicatedFolder = mainFolder.Duplicate();
Console.WriteLine("\nEstrutura duplicada:");
duplicatedFolder.Display();
// # Fim 

//# Decorator
// Criando uma bebida básica
Bebida minhaBebida = new Cafe();
Console.WriteLine($"{minhaBebida.ObterDescricao()} - R${minhaBebida.ObterCusto():0.00}");

// Adicionando complementos
minhaBebida = new Leite(minhaBebida);
minhaBebida = new Caramelo(minhaBebida);
minhaBebida = new Chantilly(minhaBebida);

// Exibindo descrição e custo final
Console.WriteLine($"{minhaBebida.ObterDescricao()} - R${minhaBebida.ObterCusto():0.00}");
// Fim Decorator