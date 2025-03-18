using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___Exercício_Aluno_e_Nota
{
    internal class Aluno
    {
        public double RA;
        public string Nome;
        public double NotaDaProva;
        public double NotaDoTrabalho;
        public double NotaFinal;

        public void CalcularMedia()
        {
            NotaFinal = (NotaDaProva + NotaDoTrabalho) / 2;
        }
        public void CalcularNotaFinal() 
        {
        }
    }
}
