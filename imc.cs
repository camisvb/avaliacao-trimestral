using System;

class Program
{
    static void Main()
    {
        // Entrada de dados
        Console.Write("Digite o peso (kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura (m): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        // Processamento (cálculo do IMC)
        double imc = peso / (altura * altura);

        // Saída do valor do IMC
        Console.WriteLine("Seu IMC é: " + imc.ToString("F2"));

        // Condicionais (classificação)
        if (imc < 18.5)
        {
            Console.WriteLine("Classificação: Magreza");
        }
        else if (imc >= 18.5 && imc <= 24.9)
        {
            Console.WriteLine("Classificação: Normal");
        }
        else if (imc >= 25 && imc <= 29.9)
        {
            Console.WriteLine("Classificação: Sobrepeso");
        }
        else if (imc >= 30 && imc <= 39.9)
        {
            Console.WriteLine("Classificação: Obesidade");
        }
        else
        {
            Console.WriteLine("Classificação: Obesidade grave");
        }

        // Pausar tela
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}