namespace Stopwatch;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S = Segundos (10s = 10 segundos)");
        Console.WriteLine("M = Minutos (1m = 1 minuto)");
        Console.Write("Quanto tempo deseja contar? ");

        var time = Console.ReadLine();
        Start(ConvertTime(time));
    }

    private static int ConvertTime(string? time)
    {
        ValidateInput(time);

        var unity = time!.Substring(time.Trim().Length - 1, 1).ToUpper();
        ValidateUnity(unity);


        bool validTime = int.TryParse(time!.Substring(0, time.Trim().Length - 1), out int realTime);
        ValidateTime(validTime);

        switch (unity)
        {
            case "S": return realTime;
            case "M": return realTime * 60;
            default: return 0;
        }
    }

    static void Start(int time)
    {
        int currentTime = 0;

        while (currentTime != time)
        {
            currentTime++;
            Console.Clear();
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

        End();
    }

    private static void End()
    {
        ShowMessage("Stopwatch finalizado!");
        Menu();
    }

    private static void ValidateUnity(string unity)
    {
        if (unity != "S" && unity != "M" && unity != "0")
            ThrowError("Unidade de tempo inválido");
    }

    private static void ValidateInput(string? time)
    {
        if (string.IsNullOrEmpty(time))
            ThrowError("Entrada não encontrada");
    }

    private static void ValidateTime(bool validTime)
    {
        if (!validTime)
            ThrowError("Entrada de tempo inválida");
    }

    private static void ThrowError(string message)
    {
        ShowMessage(message);
        Menu();
    }

    private static void ShowMessage(string message)
    {
        Console.Clear();
        Console.WriteLine(message);
        Thread.Sleep(2500);
    }
}