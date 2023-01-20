namespace TextEditor;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    private static void Menu()
    {
        Console.Clear();
        Console.WriteLine("1 - Abrir arquivo");
        Console.WriteLine("2 - Criar um novo arquivo");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("Selecione uma opção: ");

        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 0: System.Environment.Exit(0); break;
            case 1: OpenFile(); break;
            case 2: EditFile(); break;
            default: Menu(); break;
        }
    }

    private static void EditFile()
    {
        Console.Clear();
        Console.WriteLine("Digite seu texto abaixo. (EXC para finalizar)");
        Console.WriteLine("---------------------------------------------");

        string text = string.Empty;

        do
        {
            text += Console.ReadLine();
            text += Environment.NewLine;
        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);

        SaveFile(text);
    }

    private static void OpenFile()
    {
        Console.WriteLine("Qual o caminho do arquivo que deseja abrir? ");
        var path = Console.ReadLine().TrimEnd() + ".txt";

        using (var file = new StreamReader(path))
        {
            Console.Write(file.ReadToEnd());
        }

        Console.ReadKey();
        Menu();
    }

    private static void SaveFile(string text)
    {
        Console.WriteLine("Qual o caminho para salvar o arquivo? ");
        var path = Console.ReadLine().TrimEnd() + ".txt";

        using (var file = new StreamWriter(path))
        {
            file.Write(text);
        }

        Console.WriteLine("Arquivo salvo com sucesso!");
        Console.ReadLine();

        Menu();
    }
}