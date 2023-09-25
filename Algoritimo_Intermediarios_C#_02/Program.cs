Int32 numero1, numero2, numero3;

Console.WriteLine("Digite o primeiro número: ");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo números:");
numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o terceiro número");
numero3 = Convert.ToInt32(Console.ReadLine());


if (numero1 >= numero2 && numero1 >= numero3)
{
    Console.WriteLine(numero1);

    if (numero2 >= numero3)
    {
        Console.WriteLine(numero2);
        Console.WriteLine(numero3);
    }
    else
    {
        Console.WriteLine(numero3);
        Console.WriteLine(numero2);
    }
}
else if (numero2 >= numero1 && numero2 >= numero3)
{
    Console.WriteLine(numero2);

    if (numero1 >= numero3)
    {
        Console.WriteLine(numero1);
        Console.WriteLine(numero3);
    }
    else
    {
        Console.WriteLine(numero3);
        Console.WriteLine(numero1);
    }
}
else
{
    Console.WriteLine(numero3);

    if (numero1 >= numero2)
    {
        Console.WriteLine(numero1);
        Console.WriteLine(numero2);
    }
    else
    {
        Console.WriteLine(numero2);
        Console.WriteLine(numero1);
    }
}
 
