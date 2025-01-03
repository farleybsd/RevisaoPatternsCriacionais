using RevisaoPatternsEstruturais.Bridge;

namespace RevisaoPatternsEstruturais.Ponte
{
    // Abstração
    internal abstract class Transporte
    {
        protected IPlataforma plataforma;

        protected Transporte(IPlataforma plataforma)
        {
            this.plataforma = plataforma;
        }

        public abstract void IniciarOperacao();
        public abstract void EncerrarOperacao();
    }
}
/*
 A Expansão do Sistema de Transporte Urbano
Em uma cidade futurista chamada Techpolis , o

O
Durante o planejamento, a equipe acordou um problema: os meios de transporte tinham características e funcionalidades específicas, mas compartilhavam algumas operações básicas, como iniciar o transporte, encerrar a operação, e calcular a tarifa. Além disso, cada meio de transporte tinha que ser implementado em diferentes plataformas: um aplicativo web, um aplicativo móvel e um painel

Isso criou um grande dilema para a equipe de desenvolvimento

Se implementarem uma classe para cada combinação de meio de transporte e plataforma, o código ficaria rígido e difícil
Se tentarmos criar uma solução genérica única, o código ficaria desorganizado, com muitas verificações para
A equipe precisa de uma forma de separar as responsabilidades de meios de transporte eplataformas para

UM
O arquiteto de software desenvolveu a aplicação do padrão de projeto Bridge. Ele ex

Abstração :
Implementação: Ré
Ao usar o Bridge padrão ,

Adicione novos meios de transporte sem modificar as plataformas existentes.
Integrar novas plataformas sem alterar a lógica dos meios
Mantenha o código limpo e extensível, já que a abstração e a facilidade seriam
Um Ap
P

A classe abstrata "Transporte" definiria métodos como iniciarOperacao(), `eencerrarOperacao(), e `ccalcularTarifa().
Cada tipo de transporte (como ônibus ou metrô) seria uma especialização dessa resumo
As implementações específicas das plataformas (web, móvel, painel) seriam
Quando novos meios de transporte futuristas fossem introduzidos, como um táxi voador, bastaria criar uma nova classe de abstração para ele. Se uma nova plataforma foi lançada, como um aplicativo para smartwatches, seria possível adicionar uma nova implementação sem

Com essa abordagem, Techpolisconseg

*/