using _3___Exercício_Criando_um_sistema_de_Controle_de_Produtos;
using System.ComponentModel;
using System.Globalization;
using System.Collections.Generic;

Console.Write("Deseja incluir quantos produtos? ");
int n = int.Parse(Console.ReadLine());

Produto[] vetor = new Produto[n];

for (int i = 0; i < n; i++)
{

    Console.WriteLine($"Entre com os dados do {i + 1}° produto:");
    Console.Write("Nome: ");
    string nome = Console.ReadLine().ToUpper();
    Console.Write("Preço: ");
    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Produto produto = new Produto { Nome = nome, Preco = preco };
    Console.Write("Digite a quantidades a ser adicionado ao estoque: ");
    produto.AdicionarEstoque(int.Parse(Console.ReadLine()));

    Console.WriteLine();
    vetor[i] = produto;
        
}

Console.Clear();


for (int i = 0; i < n; i++)
{
    Console.WriteLine("Dados do produto: ");
    vetor[i].ExibirDetalhes();
}


bool ContinuarRemover = true;

while (ContinuarRemover)
{

    Console.WriteLine("Deseja retirar algum produto do estoque? (s/n)");
    char ReProd = char.Parse(Console.ReadLine().ToUpper());

    if (ReProd == 'S')
    {
        Console.WriteLine("Digite o nome do produto: ");
        string nomeProduto = Console.ReadLine().ToUpper();
        bool ProdutoEncontrado = false;

        for (int i = 0; i < n; i++)
        {

            if (vetor[i].Nome == nomeProduto)
            {
                Console.Write("Digite a quantidade a ser removido do estoque: ");
                vetor[i].RemoverEstoque(int.Parse(Console.ReadLine()));
                Console.Clear();

                Console.WriteLine($"Dados atualizados: ");
                for (int j = 0; j < n; j++)
                {
                    vetor[j].ExibirDetalhes();
                }



                
            }

        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine($"Dados atualizados: ");
        for (int i = 0; i < n; i++)
        {
            
            vetor[i].ExibirDetalhes();
            ContinuarRemover = false;
        }
    }
}

