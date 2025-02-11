using RevisaoPatternsComportamental.Mediator;

// Cria a torre de controle (Mediator)
        ITorreControle torre = new TorreControle();

// Cria os aviões (Colleagues)
Aviao aviao1 = new Aviao("Voo 101", torre);
Aviao aviao2 = new Aviao("Voo 202", torre);
Aviao aviao3 = new Aviao("Voo 303", torre);

// Aviões enviam mensagens através da torre
aviao1.EnviarMensagem("Pronto para decolar.");
aviao2.EnviarMensagem("Solicitando permissão para pousar.");
aviao3.EnviarMensagem("Na fila para decolagem.");