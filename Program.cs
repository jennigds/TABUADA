Console.Clear();

int numero, resultado, multiplicador = 0;

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;

Console.WriteLine("=-=-=-=TABUADA-=-=-=-\n");

Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;

Console.Write("DIGITE O NÚMERO PARA A TABUADA: ");
numero = Convert.ToInt32(Console.ReadLine());

Console.ResetColor();

while (multiplicador <=10)
{
resultado = numero * multiplicador;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{numero} x {multiplicador} = {resultado}");
multiplicador +=1;
Console.ResetColor();
}
