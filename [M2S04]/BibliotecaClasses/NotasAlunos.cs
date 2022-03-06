namespace BibliotecaClasses
{
    public class NotasAlunos : NotasProtected
    {
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }
        public int Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }
        public int Nota3
        {
            get { return nota3; }
            set { nota3 = value; }
        }
        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
    }
}
