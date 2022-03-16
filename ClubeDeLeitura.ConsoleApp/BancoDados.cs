using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDeLeitura.ConsoleApp
{
    public class BancoDados
    {
        public Caixa[] Caixas = new Caixa[5];
        public Revista[] Revistas = new Revista[10];

        internal void SalvarCaixa(Caixa caixa)
        {
            throw new NotImplementedException();
        }

        internal void SalvarRevista(Revista revista)
        {
            throw new NotImplementedException();
        }
    }
}
