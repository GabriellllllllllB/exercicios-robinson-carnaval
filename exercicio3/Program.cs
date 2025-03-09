int n;

Console.WriteLine("escreva o numero");
n = int.Parse(Console.ReadLine());

switch (n)
{
    case 1:
        Console.WriteLine("domingo");
        break;
    case 2:
        Console.WriteLine("segunda");
        break;
    case 3:
        Console.WriteLine("terça");
        break;
    case 4:
        Console.WriteLine("quarta");
        break;
    case 5:
        Console.WriteLine("quinta");
        break;
    case 6:
        Console.WriteLine("sexta");
        break;
    case 7:
        Console.WriteLine("sabado");
        break;
    default:
        Console.WriteLine("dia incorreto");
        break;
}