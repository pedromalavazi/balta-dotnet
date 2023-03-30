namespace EditorHtml;

public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;

        DrawScreen();
    }

    public static void DrawScreen()
    {
        SetLine();

        SetColumns();

        SetLine();
    }

    private static void SetColumns()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.Write("|");
            for (int j = 0; j <= 30; j++)
                Console.Write(" ");
            Console.Write("|");
            Console.Write("\n");
        }
    }

    private static void SetLine()
    {
        Console.Write("+");
        for (int i = 0; i <= 30; i++)
            Console.Write("-");
        Console.Write("+");
        Console.Write("\n");
    }
}