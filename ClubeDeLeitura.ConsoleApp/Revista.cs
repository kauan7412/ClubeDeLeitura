

namespace ClubeDeLeitura.ConsoleApp
{
    public class Revista
    {
        public string Edicao;
        public string Tipo;
        public int Serie;
        public int Ano;
        public Caixa Caixa;

        public Revista(string edicao,string tipo, int serie, int ano, Caixa caixa)
        {
            Edicao = edicao;
            Tipo = tipo;
            Serie = serie;
            Ano = ano;
            Caixa = caixa;
        }
    }
}
