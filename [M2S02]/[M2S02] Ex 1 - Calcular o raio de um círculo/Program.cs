// Faça um programa que peça o raio de um círculo, calcule e mostre sua área.

double raioDoCirculo = 0;
Console.WriteLine(" Informe um valor de raio do Círculo: ");
raioDoCirculo = double.Parse(Console.ReadLine());
Console.WriteLine("A área do circulo é : {0}", Math.PI * Math.Pow(2, raioDoCirculo));
Console.ReadKey();