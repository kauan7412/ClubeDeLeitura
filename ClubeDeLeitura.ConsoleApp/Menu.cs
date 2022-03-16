using System;


namespace ClubeDeLeitura.ConsoleApp
{
    public class Menu
    {
        BancoDados BancoDados = new BancoDados();
        public string opcao;
        public void ApresentacaoDoMenu()
        {
            Console.WriteLine("Clube de leitura");

            Console.WriteLine("Digite 1 para registrar uma nova revista");

            Console.WriteLine("Digite 2 para registrar um novo amigo");

            Console.WriteLine("Digite 3 para registrar a revista emprestada");

            Console.WriteLine("Digite 4 para visualizar o historico");

            Console.WriteLine("Digite s para sair");

            opcao = Console.ReadLine();
        }
        public void MostrarOpcao()
        {
            if(opcao == "1")
            {
                CadastrarRevista();
                CadastrarCaixa();
            }
        }

        private void CadastrarCaixa()
        {
            Console.WriteLine("digite a etiqueta da caixa");
            string Etiqueta = Console.ReadLine();
            Console.WriteLine("digite o numero da caixa");
            int Numero =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite a cor da caixa");
            string Cor = Console.ReadLine();
            Caixa caixa = new Caixa(Etiqueta, Numero, Cor);
            BancoDados.SalvarCaixa(caixa);
        }

        public void CadastrarRevista()
        {
            
            Console.Clear();
            Console.WriteLine("digite o nome da revista");
            string edicao = Console.ReadLine();
            Console.WriteLine("digite o tipo da revista");
            string tipo = Console.ReadLine();
            Console.WriteLine("digite a serie da revista");
            int serie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o ano da revista");
            int ano = Convert.ToInt32(Console.ReadLine());
            // pegar caixa = array de caixas = pegar posição da caixa = mostrar caixas
            MostrarCaixas()
           
            Revista revista = new Revista(edicao,tipo,serie,ano);

            BancoDados.SalvarRevista(revista);
           
            

        }

        private void MostrarCaixas()
        {
            for(int i = 0; i < BancoDados.Caixas.Length; i++)
            {
                if (BancoDados.Caixas[i] != null)
                {
                    Console.WriteLine($"{BancoDados.Caixas[i]}");
                }
            }
        }

        public bool OpcaoInvalida()
        {
            return
                opcao != "1" &&
                opcao != "2" &&
                opcao != "3" &&
                opcao != "4" &&
                opcao != "s";
        }
        public bool Sair()
        {
            return opcao == "s";
        }
    }
}
