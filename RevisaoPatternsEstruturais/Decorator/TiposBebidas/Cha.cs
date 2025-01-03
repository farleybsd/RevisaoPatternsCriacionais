using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoPatternsEstruturais.Decorator.TiposBebidas
{
    // Implementações concretas de bebidas
    //Imagine que você está desenvolvendo um sistema para uma cafeteria onde os clientes podem personalizar suas bebidas (chá)
    internal class Cha : Bebida
    {
        public override double ObterCusto()
        {
            return 2.50;
        }

        public override string ObterDescricao()
        {
            return "Chá";
        }
    }
}
