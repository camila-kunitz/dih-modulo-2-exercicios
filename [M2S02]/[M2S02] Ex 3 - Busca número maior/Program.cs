// Faça um programa que peça 5 números e mostre o maior deles.

var numeros = new int[5];
var maior = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Informe o {i + 1}° número inteiro:");
    numeros[i] = Convert.ToInt32(Console.ReadLine());

    if (numeros[i] > maior)
    {
        maior = numeros[i];
    }

}

Console.WriteLine($"O maior número é {maior}");
Console.ReadKey();