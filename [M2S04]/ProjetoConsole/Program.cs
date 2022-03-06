
using BibliotecaClasses;

namespace ProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 4 - Classe Estática - Calculadora

            int somar1 = Calculadora.Somar(10, 5);

            Console.WriteLine("-------------------------");
            Console.WriteLine($"O resultado da soma dos números inteiros = {somar1}");

            int subtrair1 = Calculadora.Subtrair(100, 30);

            Console.WriteLine("-------------------------");
            Console.WriteLine($"O resultado da subtração dos números inteiros = {subtrair1}");

            int multiplicar1 = Calculadora.Multiplicar(3, 5);

            Console.WriteLine("-------------------------");
            Console.WriteLine($"O resultado da multiplicação de números inteiros = {multiplicar1}");

            // Exercício 6 - Sobrecarga de Métodos 

            int somar2 = Calculadora.Somar(10, 5, 14);

            Console.WriteLine("-------------------------");
            Console.WriteLine($"O resultado da soma dos números inteiros = {somar2}");

            int subtrair2 = Calculadora.Subtrair(330, 100, 60);

            Console.WriteLine("-------------------------");
            Console.WriteLine($"O resultado da subtração dos números inteiros = {subtrair2}");

            int multiplicar2 = Calculadora.Multiplicar(3, 5, 2);

            Console.WriteLine("-------------------------");
            Console.WriteLine($"O resultado da multiplicação de números inteiros = {multiplicar2}");


            // Exercício 5 - Contrutor de classe - Docente 

            Docente professor = new Docente();
            professor.Nome = "Alessandra";
            professor.Disciplina = "C#";
            professor.CargaHorariaAula = 70;

            Console.WriteLine("------------- USUÁRIO CONSTRUTOR PADRÃO ----------------------------");
            Console.WriteLine($"Nome do professor = {professor.Nome}");
            Console.WriteLine($"disciplina dada pelo professor = {professor.Disciplina}");
            Console.WriteLine($"Carga Horária de Aula  = {professor.CargaHorariaAula}");
            Console.WriteLine("--------------------------------------------------------------");

            Docente professorSubstituto = new Docente("João", "C#", 10);

            Console.WriteLine("------------- USUÁRIO CONSTRUTOR COM ARGUMENTOS----------------------");
            Console.WriteLine($"nome do professor Substituto = {professorSubstituto.Nome}");
            Console.WriteLine($"disciplina dada pelo professor = {professorSubstituto.Disciplina}");
            Console.WriteLine($"Carga Horária de Aula = {professorSubstituto.CargaHorariaAula}");
            Console.WriteLine("--------------------------------------------------------------");
        }
    }
}
