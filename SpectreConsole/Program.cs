using Spectre.Console;

<<<<<<< Updated upstream
AnsiConsole.MarkupLine("[red bold]Hello, world![/]");
AnsiConsole.MarkupLine("Hello, world!");
AnsiConsole.MarkupLine("[slowblink]Hello, world![/]");

Console.ReadLine();
AnsiConsole.Clear();
=======
#region Lesson 02 - Initial Setup
//AnsiConsole.MarkupLine("[red bold]Hello, world![/]");
//AnsiConsole.MarkupLine("Hello, world!");
//AnsiConsole.MarkupLine("[slowblink]Hello, world![/]");
#endregion


#region Lesson 03 - Using Styles
Style danger = new(
    foreground: Color.Red,
    background: Color.White,
    decoration: Decoration.Bold | Decoration.Italic | Decoration.Strikethrough);

AnsiConsole.Write(new Markup("Danger Text from Style!\n", danger));
#endregion

Console.ReadLine();
AnsiConsole.Clear();

>>>>>>> Stashed changes
