using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o lado do triângulo equilátero: ");

        if (double.TryParse(Console.ReadLine(), out double lado);
        {
            double area = (Math.Sqrt(3) / 4) * (lado * lado);
            Console.WriteLine("Área do triângulo: " + area);
        }
        else
        {
            Console.WriteLine("Valor inválido! Digite um número.");
        }
    }
}