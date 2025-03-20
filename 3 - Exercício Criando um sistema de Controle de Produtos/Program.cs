using _3___Exercício_Criando_um_sistema_de_Controle_de_Produtos;
using System.ComponentModel;
using System.Globalization;
using System.Collections.Generic;


Produto produto = new Produto();

Console.WriteLine("Entre com os dados do produto:");
Console.Write("Nome: ");
produto.Nome = Console.ReadLine().ToUpper();
Console.Write("Preço: ");
produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");
produto.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Clear();
Console.WriteLine($"Dados do produto: ");
produto.ExibirDetalhes();


Console.Write("Digite o numero de produtos a ser adicionado do estoque: ");
produto.AdicionarEstoque(int.Parse(Console.ReadLine()));

Console.Clear();

Console.WriteLine($"Dados atualizados: ");
produto.ExibirDetalhes();

Console.Write("Digite o numero de produtos a ser removido do estoque: ");
produto.RemoverEstoque(int.Parse(Console.ReadLine()));

Console.Clear();

Console.WriteLine($"Dados atualizados: ");
produto.ExibirDetalhes();