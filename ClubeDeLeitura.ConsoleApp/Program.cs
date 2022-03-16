using System;

namespace ClubeDeLeitura.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Notificador notificador = new Notificador();
            Menu menu = new Menu();

            while (true)
            {
                Console.Clear();
                menu.ApresentacaoDoMenu();
                if (menu.Sair())
                    break;
                if (menu.OpcaoInvalida())
                {
                    notificador.ApresentarMensagem("Opção inválida: tente novamente", ConsoleColor.Red);
                    continue;
                }
                menu.MostrarOpcao();
            }
        }
    }
}
