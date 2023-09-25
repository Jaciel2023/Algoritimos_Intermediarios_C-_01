
Int32 numero1, numero2, numero3, maiorNumero, menorNumero;


Console.WriteLine("Digite o primeiro número: ");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o Segundo número");
numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o Terceiro número");
numero3 = Convert.ToInt32(Console.ReadLine());


if (numero1 > numero2 && numero1 > numero3)
{
    Console.WriteLine ( "Numero " + numero1+ " é o maior");
}
if (numero2 > numero1 && numero2 > numero3)
{
    Console.WriteLine("Numero " + numero2 + " é o maior");
}
else if (numero3 > numero1 && numero3 > numero2)
{
    Console.WriteLine("Numero " + numero3 + " é o maior");
}
    if (numero1 < numero2 && numero1 < numero3)
    {
        Console.WriteLine ( "Numero " + numero1 + " é o menor");
    }
    if (numero2 < numero1 && numero2 < numero3)
    {
        Console.WriteLine ( "Numero  " + numero2 + " é o menor");
    }
   else if (numero3 < numero1 && numero3 < numero2)
    {
        Console.WriteLine ( "Numero " + numero3 + " é o menor") ;
    }
