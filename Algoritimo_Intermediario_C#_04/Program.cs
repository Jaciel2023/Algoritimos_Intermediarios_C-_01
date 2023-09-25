    Int32 n, soma;
    {
    Console.Write("Digite um valor inteiro e positivo: ");
    n = Convert.ToInt32(Console.ReadLine());

         soma = 0.0;
        for (int i = 1; i <= n; i++)
        {
            soma += 1.0 / i;
        }

        Console.WriteLine("A soma é: " + soma);
    }