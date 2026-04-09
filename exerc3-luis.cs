using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha o tipo de organismo para catalogar:");
        Console.WriteLine("1 - Euglenófitas");
        Console.WriteLine("2 - Clorófitas");
        Console.WriteLine("3 - Bacillariófitas");
        Console.WriteLine("4 - Rodofíceas");
        Console.WriteLine("5 - Pirrófitas");
        Console.WriteLine("6 - Amebas");
        Console.WriteLine("7 - Toxoplasma");
        Console.WriteLine("8 - Filariose");
        Console.WriteLine("9 - Tripomastigotas");

        Console.Write("Digite sua opção: ");

        if (int.TryParse(Console.ReadLine(), out int opcao))
        {
            switch (opcao)
            {
                case 1: Console.WriteLine("Você escolheu catalogar Euglenófitas."); break;
                case 2: Console.WriteLine("Você escolheu catalogar Clorófitas."); break;
                case 3: Console.WriteLine("Você escolheu catalogar Bacillariófitas."); break;
                case 4: Console.WriteLine("Você escolheu catalogar Rodofíceas."); break;
                case 5: Console.WriteLine("Você escolheu catalogar Pirrófitas."); break;
                case 6: Console.WriteLine("Você escolheu catalogar Amebas."); break;
                case 7: Console.WriteLine("Você escolheu catalogar Toxoplasma."); break;
                case 8: Console.WriteLine("Você escolheu catalogar Filariose."); break;
                case 9: Console.WriteLine("Você escolheu catalogar Tripomastigotas."); break;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
        else
        {
            Console.WriteLine("Valor inválido! Digite um número de 1 a 9.");
        }
    }
}