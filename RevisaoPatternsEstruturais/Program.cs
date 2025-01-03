// #### Adapter ###
using RevisaoPatternsEstruturais.Adapter;
using RevisaoPatternsEstruturais.Bridge;
using RevisaoPatternsEstruturais.Bridge.MeiosDeTransporte;
using RevisaoPatternsEstruturais.Bridge.Plataformas;
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