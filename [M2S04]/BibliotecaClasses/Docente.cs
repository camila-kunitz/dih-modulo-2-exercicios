namespace BibliotecaClasses
{
    public class Docente
    {
        public string Nome { get; set; }
        public string Disciplina { get; set; }
        public int CargaHorariaAula { get; set; }

        public Docente() {}

        public Docente(string nome, string disciplina, int cargaHorariaAula)
        {
            Nome = nome;
            Disciplina = disciplina;
            CargaHorariaAula = cargaHorariaAula;
        }
    }
}
