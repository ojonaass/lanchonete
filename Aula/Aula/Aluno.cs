namespace Aula
{
    class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }

        public bool AlunoEstaAprovado()
        {            
            return ObterMedia >= 7;
        }
        public bool IndicadoParaMercado()
        {
            return ObterMedia >= 9;
        }
        public double ObterMedia => ((Nota1 + Nota2 + Nota3 + Nota4) / 4);
    }
}
