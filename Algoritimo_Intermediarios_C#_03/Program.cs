Decimal valorHora, horasTrabalhadasMes, FGTS = 11, impostoDeRenda = 0, sindicato = 3, totalDescontos, salarioLiquido = 0, salarioBruto;

Console.WriteLine("Digite o valor da hora do(a) funcionário(a): R$");
valorHora = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o total de horas trabalhadas do(a) funcionário(a) no mês: ");
horasTrabalhadasMes = Convert.ToDecimal(Console.ReadLine());

;

salarioBruto = valorHora * horasTrabalhadasMes;
sindicato = salarioBruto * 0.03m;
FGTS = salarioBruto * 0.11m;
totalDescontos = impostoDeRenda + sindicato;

if (salarioBruto <= 900)
{
    salarioLiquido = salarioBruto;
    totalDescontos = impostoDeRenda + sindicato;
    salarioLiquido = salarioBruto - totalDescontos;

}
if (salarioBruto >= 901 && salarioBruto <= 1500)
{
    impostoDeRenda = salarioBruto * 0.10m;
    totalDescontos = impostoDeRenda + sindicato;
    salarioLiquido = salarioBruto - totalDescontos;

}
if (salarioBruto >= 1501 && salarioBruto <= 2500)
{
    impostoDeRenda = salarioBruto * 0.10m;
    totalDescontos = impostoDeRenda + sindicato;
    salarioLiquido = salarioBruto - totalDescontos;

}
else if (salarioBruto > 2500)
{
    impostoDeRenda = salarioBruto * 0.10m;
    totalDescontos = impostoDeRenda + sindicato;
    salarioLiquido = salarioBruto - totalDescontos;

    

}
Console.WriteLine("O salário bruto do funcionário(a) foi: R$" + salarioBruto);
Console.WriteLine("Imposto de renda descontado foi de: R$" + impostoDeRenda);
Console.WriteLine("O desconto sindical: R$" + sindicato);
Console.WriteLine("Descontos do FGTS: R$" + FGTS);
Console.WriteLine("Salário liquido do funcionário(a) no mês foi de: R$" + salarioLiquido);
Console.WriteLine("Total de descontos foi de: R$" + totalDescontos);

