using System;

namespace calculator;

class Program
{
    static void Main(string[] args)
    {
        RunMenu();
    }

    private static void RunMenu()
    {
        Console.Clear();
        Console.WriteLine("1 -> Soma");
        Console.WriteLine("2 -> Subtração");
        Console.WriteLine("3 -> Divisão");
        Console.WriteLine("4 -> Multiplicação");
        Console.WriteLine("5 -> Sair");
        Console.WriteLine();
        Console.Write("Escolha a operação desejada: ");
        string? option = Console.ReadLine();

        if (string.IsNullOrEmpty(option))
            RunMenu();

        switch (option!.Trim())
        {
            case "1": Soma(); break;
            case "2": Subtracao(); break;
            case "3": Divisao(); break;
            case "4": Multiplicacao(); break;
            case "5": Environment.Exit(0); break;
            default: RunMenu(); break;
        }
    }

    static void Soma()
    {
        Console.Clear();

        Console.Write("Primeiro valor: ");
        float firstValue = float.Parse(Console.ReadLine() ?? "");

        Console.Write("Segundo valor: ");
        float secondValue = float.Parse(Console.ReadLine() ?? "");

        Console.WriteLine($"A soma é: {firstValue + secondValue}");

        Console.ReadKey();
        RunMenu();
    }

    static void Subtracao()
    {
        Console.Clear();

        Console.Write("Primeiro valor: ");
        float firstValue = float.Parse(Console.ReadLine() ?? "");

        Console.Write("Segundo valor: ");
        float secondValue = float.Parse(Console.ReadLine() ?? "");

        Console.WriteLine($"A subtração é: {firstValue - secondValue}");

        Console.ReadKey();
        RunMenu();
    }

    static void Divisao()
    {
        Console.Clear();

        Console.Write("Primeiro valor: ");
        float firstValue = float.Parse(Console.ReadLine() ?? "");

        Console.Write("Segundo valor: ");
        float secondValue = float.Parse(Console.ReadLine() ?? "");

        if (secondValue == 0)
            throw new Exception("Não é possível divisão por zero");

        Console.WriteLine($"A divisão é: {firstValue / secondValue}");

        Console.ReadKey();
        RunMenu();
    }

    static void Multiplicacao()
    {
        Console.Clear();

        Console.Write("Primeiro valor: ");
        float firstValue = float.Parse(Console.ReadLine() ?? "");

        Console.Write("Segundo valor: ");
        float secondValue = float.Parse(Console.ReadLine() ?? "");

        Console.WriteLine($"A divisão é: {firstValue * secondValue}");

        Console.ReadKey();
        RunMenu();
    }
}

