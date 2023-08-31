using ex06DIA31.AlunoEAD;

namespace ex06DIA31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ALUNOS aL1 = new ALUNOS("ALLAN", "45707361812", 25, "MASCULINO", 310001);
            aL1.Visualizar();
            ALUNOS aL2 = new ALUNOS("ADAILTON", "165556676902", 45, "MASCULINO", 310002);
            aL2.Visualizar();
        }
    }
}