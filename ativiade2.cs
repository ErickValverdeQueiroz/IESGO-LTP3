using System;

namespace TesteDeProjeto
{
    class Program
    {
        const int MinLadoDado = 1;
        const int MaxLadoDado = 7; // Alterado para 7 para incluir o 6 como possível resultado

        static void Main(string[] args)
        {
            Random numberGen = new Random();

            int giroDado1 = 0;
            int giroDado2 = 1;
            int tentativas = 0;

            Console.WriteLine("Pressione Enter para girar os dados ou 'Q' para sair.");

            while (giroDado1 != giroDado2)
            {
                var key = Console.ReadKey().Key;

                if (key == ConsoleKey.Q)
                {
                    Console.WriteLine("\nSaindo do jogo.");
                    return;
                }
                else if (key == ConsoleKey.Enter)
                {
                    giroDado1 = RolarDado(numberGen);
                    giroDado2 = RolarDado(numberGen);
                    tentativas++;

                    Console.WriteLine($"\nVocê rolou {giroDado1} e o outro dado rolou {giroDado2}");

                    if (giroDado1 != giroDado2)
                    {
                        double chance = 1.0 / (MaxLadoDado - MinLadoDado);
                        double porcentagemChance = chance * 100;
                        Console.WriteLine($"A chance de rolar um par é de {porcentagemChance:F2}%");
                    }
                }
            }

            Console.WriteLine($"\nVocê precisou de {tentativas} tentativas para rolar um par de números iguais.");

            // Esperar antes de encerrar
            Console.ReadKey();
        }

        static int RolarDado(Random random)
        {
            return random.Next(MinLadoDado, MaxLadoDado);
        }
    }
}