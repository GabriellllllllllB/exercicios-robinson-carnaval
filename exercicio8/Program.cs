int[] d = new int[20];
int n;
int c =0;

Console.WriteLine("escreva 20 numeros:");
for (int i = 0; i < 20; i++)
{
    Console.WriteLine("escreva os numeros: ");
    d[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("escreva o valor n:");
n = int.Parse(Console.ReadLine());

Console.WriteLine("vetor compactado em elementos maior que n:");
for (int i = 0; i < 20; i++)
{
    if (d[i] > n)
    {
        Console.WriteLine(d[i]);
        c++;
    }
}

if (c == 0)
{
    Console.WriteLine("nenhum numero maior que n");
}