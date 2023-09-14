using System;

namespace ComparacaoDeValores
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int altura;
            double peso;

            // Adicione validação de entrada para idade
            while (true)
            {
                Console.WriteLine("Por favor, insira sua idade:");
                if (int.TryParse(Console.ReadLine(), out idade))
                {
                    break; // Sai do loop se a entrada for um número válido
                }
                else
                {
                    Console.WriteLine("Idade inválida. Insira novamente.");
                }
            }

            // Adicione validação de entrada para altura
            Console.WriteLine("Por favor, insira sua altura em centímetros:");
            if (!int.TryParse(Console.ReadLine(), out altura))
            {
                Console.WriteLine("Altura inválida. Insira um número inteiro.");
                return; // Encerra o programa se a altura for inválida
            }

            // Adicione validação de entrada para peso
            while (true)
            {
                Console.WriteLine("Por favor, insira seu peso em quilogramas:");
                if (double.TryParse(Console.ReadLine(), out peso))
                {
                    break; // Sai do loop se a entrada for um número válido
                }
                else
                {
                    Console.WriteLine("Peso inválido. Insira novamente.");
                }
            }

            // Adicione uma função para calcular o IMC
            double alturaMetros = altura / 100.0; // Converter altura para metros
            double imc = peso / (alturaMetros * alturaMetros);

            // Imprimir a categoria de IMC
            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso.");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Você tem um peso normal.");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Você está com sobrepeso.");
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("Você está com obesidade grau I.");
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine("Você está com obesidade grau II (severa).");
            }
            else
            {
                Console.WriteLine("Você está com obesidade grau III (mórbida ou mórbida severa).");
            }

            // Avaliar a idade e altura
            if (idade > 18 && altura > 170)
            {
                Console.WriteLine("Você é maior de 18 anos e tem mais de 170 cm de altura.");
            }
            else if (idade > 18 || altura > 170)
            {
                if (idade > 18)
                {
                    Console.WriteLine("Você é maior de 18 anos.");
                }
                if (altura > 170)
                {
                    Console.WriteLine("Você tem mais de 170 cm de altura.");
                }
            }
            else
            {
                Console.WriteLine("Você não atende a nenhum dos critérios acima.");
            }

            // Verificar se a idade é igual a 21
            if (idade == 21)
            {
                Console.WriteLine("Você tem exatamente 21 anos!");
            }
            else
            {
                Console.WriteLine("Você não tem 21 anos.");
            }
        }
    }
}