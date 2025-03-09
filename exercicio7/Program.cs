int[] r = new int[5];
int[] a = new int[10];
int p = 0;
int i;
int j;

Console.WriteLine("escreva os 5 numeros do gabarito: ");
for (i = 0; i < 5; i++)
{
    Console.Write("escreva o numero:");
    r[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("escreva os 10 numeros da aposta: ");
for (i = 0; i < 10; i++)
{
    Console.Write("escreva o numero:");
    a[i] = int.Parse(Console.ReadLine());
}

for (i = 0; i < 5; i++)
{
    for (j = 0; j < 10; j++)
    {
        if (r[i] == a[j])
        {
            p++;
        }
    }
}

Console.WriteLine("voce acertou " + p + " numeros");