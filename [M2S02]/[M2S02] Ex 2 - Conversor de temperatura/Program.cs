// Faça um programa que peça a temperatura em graus Celsius e retorne a temperatura em Fahrenheit.


Console.WriteLine("Digite um valor de temperatura em Celsius: ");
var celsius = double.Parse(Console.ReadLine());

var fahrenheit = (celsius * 9 / 5) + 32;

Console.WriteLine($"A temperatura convertida em Fahrenheit é: {fahrenheit}");

Console.ReadKey();
