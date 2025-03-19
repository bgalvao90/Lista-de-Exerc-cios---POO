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
            if (NotaFinal >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                double notaRecuperacao = 12 - (NotaFinal / 2) ;
                Console.WriteLine($"Reprovado! Será necessário de {notaRecuperacao} pontos ");
            }
        }
        public void ImprimirNotaFinal()
        {
            Console.WriteLine($"Nota final: {NotaFinal}");
        }
        public void ReceberDados()
        {
            RA = double.Parse(Console.ReadLine());
            Nome = Console.ReadLine();
            NotaDaProva = double.Parse(Console.ReadLine());
            NotaDoTrabalho = double.Parse(Console.ReadLine());
        }
    }
}
