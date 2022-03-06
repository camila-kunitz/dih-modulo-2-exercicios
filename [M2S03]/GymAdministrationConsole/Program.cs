using GymAdministration.Core;
using System;

namespace GymAdministrationConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student estudante01 = new Student("Estudante 01", "Sem observação", new DateTime(1990, 1, 1));
            Student estudante02 = new Student("Estudante 02", "Sem observação", new DateTime(1991, 2, 2));
            Student estudante03 = new Student("Estudante 03", "Sem observação", new DateTime(1992, 3, 3));
            Student estudante04 = new Student("Estudante 04", "Sem observação", new DateTime(1993, 4, 4));
            Student estudante05 = new Student("Estudante 05", "Sem observação", new DateTime(1994, 5, 5));
            Student estudante06 = new Student("Estudante 06", "Sem observação", new DateTime(1995, 6, 6));
            Student estudante07 = new Student("Estudante 07", "Sem observação", new DateTime(1996, 7, 7));
            Student estudante08 = new Student("Estudante 08", "Sem observação", new DateTime(1997, 8, 8));
            Student estudante09 = new Student("Estudante 09", "Sem observação", new DateTime(1998, 9, 9));
            Student estudante10 = new Student("Estudante 10", "Sem observação", new DateTime(1999, 10, 10));

            List<Student> students = new List<Student>();
            students.Add(estudante01);
            students.Add(estudante02);
            students.Add(estudante03);
            students.Add(estudante04);
            students.Add(estudante05);
            students.Add(estudante06);
            students.Add(estudante07);
            students.Add(estudante08);
            students.Add(estudante09);
            students.Add(estudante10);

            Employee professor01 = new Employee("Profssor 01");

            ActivityClass aulaFuncional = new ActivityClass("Jump", "Exrcícios utilizando cama elástica", new DateTime(2022, 2, 27));
            aulaFuncional.Students = students;
            aulaFuncional.Employee = professor01;

            Equipament equipamento01 = new Equipament(01, "Cama elástica 01", "Cama elástica profissional marca X", new DateTime(2022, 1, 1));
            Equipament equipamento02 = new Equipament(02, "Cama elástica 02", "Cama elástica profissional marca X", new DateTime(2022, 1, 1));
            Equipament equipamento03 = new Equipament(03, "Cama elástica 03", "Cama elástica profissional marca X", new DateTime(2022, 1, 1));
            Equipament equipamento04 = new Equipament(04, "Cama elástica 04", "Cama elástica profissional marca X", new DateTime(2022, 1, 1));
            Equipament equipamento05 = new Equipament(05, "Cama elástica 05", "Cama elástica profissional marca X", new DateTime(2022, 1, 1));
            Equipament equipamento06 = new Equipament(06, "Cama elástica 06", "Cama elástica profissional marca X", new DateTime(2022, 1, 1));
            Equipament equipamento07 = new Equipament(07, "Cama elástica 07", "Cama elástica profissional marca X", new DateTime(2022, 1, 1));
            Equipament equipamento08 = new Equipament(08, "Cama elástica 08", "Cama elástica profissional marca X", new DateTime(2022, 1, 1));
            Equipament equipamento09 = new Equipament(09, "Cama elástica 09", "Cama elástica profissional marca X", new DateTime(2022, 1, 1));
            Equipament equipamento10 = new Equipament(10, "Cama elástica 10", "Cama elástica profissional marca X", new DateTime(2022, 1, 1));

            List<Equipament> equipamentos = new List<Equipament>();
            equipamentos.Add(equipamento01);
            equipamentos.Add(equipamento02);
            equipamentos.Add(equipamento03);
            equipamentos.Add(equipamento04);
            equipamentos.Add(equipamento05);
            equipamentos.Add(equipamento06);
            equipamentos.Add(equipamento07);
            equipamentos.Add(equipamento08);
            equipamentos.Add(equipamento09);
            equipamentos.Add(equipamento10);

            Employee professor02 = new Employee("Profssor 02");
            Employee professor03 = new Employee("Profssor 03");
            Employee professor04 = new Employee("Profssor 04");
            Employee professor05 = new Employee("Profssor 05");

            List<Employee> professores = new List<Employee>();
            professores.Add(professor01);
            professores.Add(professor02);
            professores.Add(professor03);
            professores.Add(professor04);
            professores.Add(professor05);


            Console.WriteLine("------------------------------");
            Console.WriteLine($"Atividade: {aulaFuncional.Name}");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Descrição: {aulaFuncional.Description}");
            Console.WriteLine($"Data de início: {aulaFuncional.StartedActivity}");
            Console.WriteLine($"Professor: {aulaFuncional.Employee.Name}");
            Console.WriteLine("Lista de Alunos: ");
            aulaFuncional.Students.ForEach(student => Console.WriteLine($" >>> {student.Name}"));

            Console.WriteLine("------------------------------");
            Console.WriteLine("Equipamentos:");
            Console.WriteLine("------------------------------");
            equipamentos.ForEach(equipamento => Console.WriteLine($" >>> Equipamento: ID = {equipamento.Id} | Nome: {equipamento.Name} | Data de aquisição: {equipamento.AcquiredDate}"));

            Console.WriteLine("------------------------------");
            Console.WriteLine("Professores:");
            Console.WriteLine("------------------------------");
            professores.ForEach(professor => Console.WriteLine($" >>> {professor.Name}"));


            Console.ReadKey();        }

    }
}

    
    


