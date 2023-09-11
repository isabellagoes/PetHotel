Console.WriteLine("Bem vindo(a) ao Pet Hotel!");
Console.WriteLine("Por favor, informe as seguintes informações do seu pet: ");
Console.WriteLine();


Console.Write("Espécie: ");
string especie;
especie = Console.ReadLine()!;

Console.Write("Raça: ");
string raca;
raca = Console.ReadLine()!;

Console.Write("Alcunha: ");
string alcunha;
alcunha = Console.ReadLine()!;

Console.Write("Idade: ");
string idade;
idade = Console.ReadLine()!;

Console.Write("Pelagem/Cor: ");
string PelagemCor;
PelagemCor = Console.ReadLine()!;
Console.WriteLine();


Console.ForegroundColor = (ConsoleColor)8;
Console.WriteLine("+=========================================================+");

Console.Write("|                 ");
Console.ForegroundColor = (ConsoleColor)13;
Console.Write("Pet Hotel \"Nem um pio\"");
Console.ForegroundColor = (ConsoleColor)8;
Console.WriteLine("                  |");


Console.ForegroundColor = (ConsoleColor)8;
Console.WriteLine("+=========================================================+");

Console.Write("| Espécie: ");
Console.ForegroundColor = (ConsoleColor)11;
Console.Write(especie.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));
Console.ForegroundColor = (ConsoleColor)8;

Console.Write(" | Raça: ");
Console.ForegroundColor = (ConsoleColor)11;
Console.Write(raca.Trim().ToUpper().PadLeft(22, '.').Substring(0, 22));
Console.ForegroundColor = (ConsoleColor)8;
Console.WriteLine(" |");


Console.ForegroundColor = (ConsoleColor)8;
Console.WriteLine("+=========================================================+");

Console.Write("| Atende pela alcunha de: ");
Console.ForegroundColor = (ConsoleColor)11;
Console.Write(alcunha.Trim().ToUpper().PadLeft(31, '.').Substring(0, 31));
Console.ForegroundColor = (ConsoleColor)8;
Console.WriteLine(" |");

Console.Write("| Idade: ");
Console.ForegroundColor = (ConsoleColor)11;
Console.Write($"{idade.Trim().ToUpper().PadLeft(2, '0').Substring(0, 2)} ano(s)");
Console.ForegroundColor = (ConsoleColor)8;

Console.Write(" | Pelagem/Cor: ");
Console.ForegroundColor = (ConsoleColor)11;
Console.Write(PelagemCor.Trim().ToUpper().PadLeft(23, '.').Substring(0, 23));
Console.ForegroundColor = (ConsoleColor)8;
Console.WriteLine(" |");

Console.ForegroundColor = (ConsoleColor)8;
Console.Write("+=========================================================+");

Console.ResetColor();