    Int32 n;
    decimal soma=0;
    {
    Console.Write("Digite um valor inteiro e positivo: ");
    n = Convert.ToInt32(Console.ReadLine());

         soma = 0;
        for (int i = 1; i <= n; i++)
        {
            soma += 1 / i;
        }

        Console.WriteLine("A soma é: " + soma);
    }