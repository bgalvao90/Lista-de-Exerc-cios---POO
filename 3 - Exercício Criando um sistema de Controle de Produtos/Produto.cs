using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _3___Exercício_Criando_um_sistema_de_Controle_de_Produtos
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;




        public void ExibirDetalhes()
        {
            Console.WriteLine(Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades");
        }


        public void AdicionarEstoque(int quantidade)
        {

            Quantidade += quantidade;
        }
        public void RemoverEstoque(int quantidade)
        {
            Quantidade -= quantidade;
        }
    }
}
