// 8 - Faça um programa que leia o arquivo notas.json na raiz do projeto e retorne o nome
// dos usuários que tiveram a média menor que 5.

string text = System.IO.File.ReadAllText(@"\notas.json");

Console.WriteLine(text);
