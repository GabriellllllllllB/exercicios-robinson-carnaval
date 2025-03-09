char res;

Console.WriteLine("seu animal é mamifero? (s/n)");
res = char.Parse(Console.ReadLine());

if (res == 's')
{
    Console.WriteLine("seu animal é quadrupede? (s/n)");
    res = char.Parse(Console.ReadLine());
    if (res == 's')
    {
        Console.WriteLine("seu animal é carnivoro? (s/n)");
        res = char.Parse(Console.ReadLine());
        if (res == 's')
        {
            Console.WriteLine("seu animal é um leao");
        }
        else
        {
            Console.WriteLine("seu animal é um cavalo");
        }
    }
    else if (res == 'n')
    {
        Console.WriteLine("seu animal é bipede? (s/n)");
        res = char.Parse(Console.ReadLine());
        if (res == 's')
        {
            Console.WriteLine("seu animal é onivoro? (s/n)");
            res = char.Parse(Console.ReadLine());
            if (res == 's')
            {
                Console.WriteLine("seu animal é um homem");
            }
            else
            {
                Console.WriteLine("seu animal é um macaco");
            }
        }
        else if (res == 'n')
        {
            Console.WriteLine("seu animal é voador? (s/n)");
            res = char.Parse(Console.ReadLine());
            if (res == 's')
            {
                Console.WriteLine("seu animal é um morcego");
            }
            else
            {
                Console.WriteLine("seu animal é uma baleia");
            }
        }
    }
}else if (res == 'n')
{
    Console.WriteLine("seu animal é uma ave? (s/n)");
    res = char.Parse(Console.ReadLine());
    if (res == 's')
    {
        Console.WriteLine("seu animal é nao voador? (s/n)");
        res = char.Parse(Console.ReadLine());
        if (res == 's')
        {
            Console.WriteLine("seu animal é tropical?");
            res = char.Parse(Console.ReadLine());
            if (res == 's')
            {
                Console.WriteLine("seu animal é um avestruz");
            }
            else
            {
                Console.WriteLine("seu animal é um pinguim");
            }
        }
        else if (res == 'n')
        {
            Console.WriteLine("seu animal é um nadador (s/n)");
            res = char.Parse(Console.ReadLine());
            if (res == 's')
            {
                Console.WriteLine("seu animal é um pato");
            }
            else
            {
                Console.WriteLine("seu animal é uma aguia");
            }
        }
    }
}