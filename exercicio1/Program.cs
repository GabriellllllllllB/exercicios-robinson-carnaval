double venda;
double atual;
double novo = 0;

Console.WriteLine("escreva o valor da média mensal de vendas: ");
venda = double.Parse(Console.ReadLine());

Console.WriteLine("escreva o valor do preço atual: ");
atual = double.Parse(Console.ReadLine());

if ((venda < 500) & (atual < 30))
{
    novo = atual + (atual * 0.10);
    Console.WriteLine(novo);
}

else if ((venda >= 500) & (atual >= 30))
{
    novo = atual - (atual * 0.20);
    Console.WriteLine(novo);
}

else
{
    Console.WriteLine("o preço mantem o mesmo");
}
