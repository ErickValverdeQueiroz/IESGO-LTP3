using System;
using System.Collections.Generic;

namespace AdedonhaGame
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao jogo Adedonha!");

            int numberOfPlayers = GetNumberOfPlayers();
            List<string> players = InitializePlayers(numberOfPlayers);

            while (players.Count > 1)
            {
                string theme = GetRandomTheme();
                char letter = GetAlphabetLetter();

                Console.WriteLine($"\nTema: {theme}");
                Console.WriteLine($"Letra: {letter}");

                foreach (var player in players)
                {
                    int fingers = GetFingers(player, letter);
                    Console.WriteLine($"{player}, quantos dedos você mostra? ({fingers} dedos)");
                    string word = Console.ReadLine().ToLower();

                    if (!IsWordValid(word, theme, letter))
                    {
                        Console.WriteLine($"{player} foi eliminado!");
                        players.Remove(player);
                        break;
                    }
                }
            }

            Console.WriteLine($"O vencedor é {players[0]}!");
        }

        static int GetNumberOfPlayers()
        {
            Console.Write("Quantos jogadores vão participar (entre 3 e 5)? ");
            int numberOfPlayers;
            while (!int.TryParse(Console.ReadLine(), out numberOfPlayers) || numberOfPlayers < 3 || numberOfPlayers > 5)
            {
                Console.WriteLine("Número de jogadores inválido. Por favor, escolha entre 3 e 5 jogadores.");
            }
            return numberOfPlayers;
        }

        static List<string> InitializePlayers(int numberOfPlayers)
        {
            List<string> players = new List<string>();
            for (int i = 1; i <= numberOfPlayers; i++)
            {
                Console.Write($"Nome do jogador {i}: ");
                players.Add(Console.ReadLine());
            }
            return players;
        }

        static string GetRandomTheme()
        {
            List<string> themes = new List<string>
            {
                "Marca de Carros",
                "Nomes de Filmes",
                "Nomes de Cidade",
                "Nomes de País",
                "Nomes de Famosos",
                "Nomes de Frutas",
                "Nome de Comida"
            };
            int index = random.Next(themes.Count);
            return themes[index];
        }

        static char GetAlphabetLetter()
        {
            int randomNumber = random.Next(0, 26); // 26 letras no alfabeto
            char letter = (char)('A' + randomNumber);
            return letter;
        }

        static int GetFingers(string player, char letter)
        {
            Console.Write($"{player}, quantos dedos você mostra para a letra {letter}? ");
            int fingers;
            while (!int.TryParse(Console.ReadLine(), out fingers) || fingers < 0 || fingers > 10)
            {
                Console.WriteLine("Número de dedos inválido. Por favor, escolha entre 0 e 10 dedos.");
            }
            return fingers;
        }

        static bool IsWordValid(string word, string theme, char letter)
        {
            // Implemente a lógica de validação da palavra aqui
            // Certifique-se de verificar se a palavra começa com a letra e pertence ao tema
            // Você também deve verificar se a palavra já foi dita por outro jogador na mesma rodada
            return true; // Temporário - sempre retorna verdadeiro
        }
    }
}