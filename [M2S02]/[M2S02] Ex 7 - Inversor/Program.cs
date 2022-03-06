// 7 - Faça um programa que peça um número inteiro positivo e em seguida mostre este número invertido, ex:
//Insere: 6549383
//Retorna: 3839456


//Console.WriteLine("Informe um número inteiro para ser invertido: ");

Console.WriteLine("Informe um número inteiro para ser invertido: ");

int n = Convert.ToInt32(Console.ReadLine());
string s = Convert.ToString(n);
string resultado = "";

for (int i = n.ToString().Length; i > 0; i--)
{
    string a = s.Substring(i - 1, 1);
    resultado += a;
}
Console.WriteLine(resultado);

