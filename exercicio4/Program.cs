double salarioh;
int horas;
double salario;
double horaex;
double salariot;

Console.WriteLine("escreva o salario por hora: ");
salarioh = int.Parse(Console.ReadLine());

Console.WriteLine("escreva as horas trabalhadas no mes: ");
horas = int.Parse(Console.ReadLine());

salario = salarioh * 160;

if (horas <= 160)
{
    salariot = salarioh * horas;
}
else
{
    horaex = horas - 160;
    salariot = salario + (horaex * (salarioh * 1.5));
}

Console.WriteLine("o salario total é: " + salariot);