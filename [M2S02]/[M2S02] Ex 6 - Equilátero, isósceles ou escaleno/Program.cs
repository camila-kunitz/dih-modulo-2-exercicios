// Faça um Programa que peça os 3 lados de um triângulo. O programa deverá informar se os valores podem ser um triângulo.
// Indique, caso os lados formem um triângulo, se o mesmo é: equilátero, isósceles ou escaleno.

//Dicas:
//Três lados formam um triângulo quando a soma de quaisquer dois lados for maior que o terceiro;
//Triângulo Equilátero: três lados iguais;
//Triângulo Isósceles: quaisquer dois lados iguais;
//Triângulo Escaleno: três lados diferentes;

int n1, n2, n3;

Console.Write("Informe um lado para o Triângulo:");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe um segundo lado para o Triângulo:");
n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe um terceiro lado para o Triângulo:");
n3 = Convert.ToInt32(Console.ReadLine());


if (n1 == n2 && n1 == n3 && n2 == n3)
{
    Console.Write("^^^TRIANGULO EQUILATERO - TRES LADOS IGUAIS^^^");
}

else if (n1 != n2 && n1 != n3 && n2 != n3)
{
    Console.Write(">>>TRIANGULO ESCALENO - TRES LADOS DIFERENTES>>>");
}

else
{
    Console.Write("TRIANGULO ISOSCELES - DOIS LADOS IGUAIS");
}

Console.ReadKey();