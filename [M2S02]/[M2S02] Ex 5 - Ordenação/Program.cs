// 5 - Faça um programa que peça 10 números e retorne todos em ordem decrescente.

var numeros = new List<int>();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Informe o {i + 1}º número:");
    numeros.Add(Convert.ToInt32(Console.ReadLine()));
}

var listaInvertida = numeros.OrderByDescending(x => x).ToList();

Console.WriteLine("Números digitados: ");
listaInvertida.ForEach(numero => Console.WriteLine(numero));



// --------- OUTRA SUGESTÃO DE RESOLUÇÃO: -----------


//var numeros = new int[3];

//for (int i = 0; i < numeros.Length; i++)
//{
//    Console.WriteLine($"Informe o {i + 1}° número inteiro:");
//    numeros[i] = Convert.ToInt32(Console.ReadLine());
//}

//var ordemDecrescente = numeros.OrderByDescending(x => x).ToArray();

//Console.WriteLine("O resultado decrescente dos números é: ");


//foreach (int item in ordemDecrescente)
//{
//    Console.WriteLine(item);
//}

//Console.ReadKey();

