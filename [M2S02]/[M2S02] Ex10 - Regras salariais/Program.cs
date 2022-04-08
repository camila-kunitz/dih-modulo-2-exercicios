// Uma loja virtual resolveu aplicar um aumento para todos os seus colaboradores e contratou o time do devinhouse para desenvolver esse programa.
// Será necessário desenvolver um programa que recebe o salário de um colaborador e aplique as seguintes regras:
// • salários até R$ 280,00: aumento de 20%
// • salários entre R$ 280,00 e R$ 700,00: aumento de 15%
// • salários entre R$ 700,00 e R$ 1500,00: aumento de 10%
// • salários de R$ 1500,00 em diante: aumento de 5%.
// Após o aumento ser realizado, informe na tela:
// • o salário antes do reajuste;
// • o percentual de aumento aplicado;
// • o valor do aumento;
// • o novo salário, após o aumento.

class Exercicio10
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o salario a ser reajustado:");
        var salario = Int32.Parse(Console.ReadLine());
        var percentual = calcularPercentual(salario);
        var aumento = salario * percentual;
        var salarioReajustado = salario + aumento;

        Console.WriteLine("\nCálculos do reajuste:");
        Console.WriteLine($">>> Salário original: {salario}");
        Console.WriteLine($">>> Percentual de reajuste: {percentual}");
        Console.WriteLine($">>> Valor do aumento: {aumento}");
        Console.WriteLine($">>> Salário reajustado: {salarioReajustado}");
    }

    static double calcularPercentual(double salario)
    {
        if (salario < 280)
        {
            return 0.2;
        }
        else if (salario >= 280 && salario < 700)
        {
            return 0.15;
        }
        else if (salario >= 700 && salario < 1500)
        {
            return 0.1;
        }
        else
        {
            return 0.05;
        }
    }

}