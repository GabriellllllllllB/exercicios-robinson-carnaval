double h;
char s;
char homem = 'm';
char mulher = 'f';
double peso = 0;

Console.WriteLine("escreva sua altura: ");
h = double.Parse(Console.ReadLine());

Console.WriteLine("escreva seu sexo: (Escreva a inicial em minusculo)");
s = char.Parse(Console.ReadLine());

if (s == homem)
{
    peso = (72.7 * h) - 58;
}

else if (s == mulher)
{
    peso = (62.1 * h) - 44.7;
}

Console.WriteLine($"{peso:F2}");