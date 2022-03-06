// Faça um programa que peça 7 números e mostre o menor deles.

var numeros = new int[7];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Informe o {i + 1}° número inteiro:");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

var menorNumero = numeros[0];

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] < menorNumero)
    {
        menorNumero = numeros[i];
    } 
}

Console.WriteLine($"O menor número é {menorNumero}");
Console.ReadKey();