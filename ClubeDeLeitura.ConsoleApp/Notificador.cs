﻿using System;


namespace ClubeDeLeitura.ConsoleApp
{
    public class Notificador
    {
        public void ApresentarMensagem(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
