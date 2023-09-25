Int32 numero, sequencia, final = 1;

Console.WriteLine("Digite um número positivo e inteiro: N");
numero = Convert.ToInt32(Console.ReadLine());

if (numero == 0)
{
    Console.WriteLine("0! =1");
}
else
{
    for (sequencia = 1; sequencia <= numero; sequencia++)
    {
        final *= sequencia;
    }
    Console.WriteLine(numero + "! =" + final);
}