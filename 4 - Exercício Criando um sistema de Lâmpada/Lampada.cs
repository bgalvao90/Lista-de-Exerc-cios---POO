using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Exercício_Criando_um_sistema_de_Lâmpada
{
    class Lampada
    {
        bool Ligada = false;

        public void Ligar()
        {
            if (Ligada == false)
            {
                Ligada = true;
            }
        }
        public void Desligar()
        {
            if (Ligada == true)
            {
                Ligada = false;
            }
        }
        public void MostrarEstado()
        {
            if (Ligada == true)
            {
                Console.WriteLine("Lâmpada está ligada!");
            }
            else
            {
                Console.WriteLine("Lâmpada está desligada!");
            }
        }
    }
}
