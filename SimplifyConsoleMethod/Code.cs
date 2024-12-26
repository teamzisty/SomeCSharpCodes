using System;

internal class C
{
    /// <summary>
    /// Console.Beep(int frequency, int duration);
    /// </summary>
    public static void B(int frequency, int duration) => Console.Beep(frequency, duration);

    /// <summary>
    /// Console.Clear();
    /// </summary>
    public static void Cl() => Console.Clear();

    /// <summary>
    /// Console.GetCursorPosition();
    /// </summary>
    /// <returns></returns>
    public static (int Left, int Top) GCP() => Console.GetCursorPosition();

    /// <summary>
    /// Console.Read();
    /// </summary>
    public static int R() => Console.Read();

    /// <summary>
    /// Console.ReadKey();
    /// </summary>
    public static ConsoleKeyInfo RK() => Console.ReadKey();

    /// <summary>
    /// Console.ReadKey(bool? intercept);
    /// </summary>
    public static ConsoleKeyInfo RK(bool intercept) => Console.ReadKey(intercept);

    /// <summary>
    /// Console.ReadLine();
    /// </summary>
    public static string RL() => Console.ReadLine();

    /// <summary>
    /// Console.ResetColor();
    /// </summary>
    public static void RC() => Console.ResetColor();

    /// <summary>
    /// Console.SetCursorPosition(left, top);
    /// </summary>
    public static void SCP(int left, int top) => Console.SetCursorPosition(left, top);

    /// <summary>
    /// Console.Write(string? value);
    /// </summary>
    public static void W(string? value) => Console.Write(value);

    /// <summary>
    /// Console.WriteLine();
    /// </summary>
    public static void WL() => Console.WriteLine();

    /// <summary>
    /// Console.WriteLine(string? value);
    /// </summary>
    public static void WL(string? value) => Console.WriteLine(value);

    //----------------------------------------------------------------------------//

    /// <summary>
    /// Console.ForegroundColor = color;
    /// </summary>
    public static void SFC(ConsoleColor color) => Console.ForegroundColor = color;

    /// <summary>
    /// Console.BackgroundColor = color;
    /// </summary>
    public static void SBC(ConsoleColor color) => Console.BackgroundColor = color;

    /// <summary>
    /// Console.BackgroundColor = Console.ForegroundColor;
    /// Console.ForegroundColor = Console.BackgroundColor;
    /// </summary>
    public static void SSC() { ConsoleColor BC = Console.BackgroundColor; SBC(Console.ForegroundColor); SFC(BC); }

    //----------------------------------------------------------------------------//

    /// <summary>
    /// Console.Write(Text);
    /// return Console.ReadLine();
    /// </summary>
    public static string RLp(string Text) { W(Text); return RL(); }
}

public readonly struct CC
{
    public static readonly ConsoleColor Black = ConsoleColor.Black;
    public static readonly ConsoleColor DarkBlue = ConsoleColor.DarkBlue;
    public static readonly ConsoleColor DarkGreen = ConsoleColor.DarkGreen;
    public static readonly ConsoleColor DarkCyan = ConsoleColor.DarkCyan;
    public static readonly ConsoleColor DarkRed = ConsoleColor.DarkRed;
    public static readonly ConsoleColor DarkMagenta = ConsoleColor.DarkMagenta;
    public static readonly ConsoleColor DarkYellow = ConsoleColor.DarkYellow;
    public static readonly ConsoleColor Gray = ConsoleColor.Gray;
    public static readonly ConsoleColor DarkGray = ConsoleColor.DarkGray;
    public static readonly ConsoleColor Blue = ConsoleColor.Blue;
    public static readonly ConsoleColor Green = ConsoleColor.Green;
    public static readonly ConsoleColor Cyan = ConsoleColor.Cyan;
    public static readonly ConsoleColor Red = ConsoleColor.Red;
    public static readonly ConsoleColor Magenta = ConsoleColor.Magenta;
    public static readonly ConsoleColor Yellow = ConsoleColor.Yellow;
    public static readonly ConsoleColor White = ConsoleColor.White;
}