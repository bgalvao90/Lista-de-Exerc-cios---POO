using _4___Exercício_Criando_um_sistema_de_Lâmpada;

Lampada lampada = new Lampada();

lampada.MostrarEstado();

Console.WriteLine("Digite 1 se você deseja ligar a lâmpada, 2 para desligar ou 3 para mostrar o estado da lâmpada:");
string opcao = Console.ReadLine();
while (opcao != "4")
{
    if (opcao == "1")
    {
        lampada.Ligar();
        Console.WriteLine();
        Console.WriteLine("Digite 1 se você deseja ligar a lâmpada, 2 para desligar, 3 para mostrar o estado da lâmpada ou 4 para sair:");
        opcao = Console.ReadLine();
    }
    else if (opcao == "2")
    {
        lampada.Desligar();
        Console.WriteLine();
        Console.WriteLine("Digite 1 se você deseja ligar a lâmpada, 2 para desligar, 3 para mostrar o estado da lâmpada ou 4 para sair:");
        opcao = Console.ReadLine();
    }
    else if (opcao == "3")
    {
        lampada.MostrarEstado();
        Console.WriteLine("Digite 1 se você deseja ligar a lâmpada, 2 para desligar, 3 para mostrar o estado da lâmpada ou 4 para sair:");
        opcao = Console.ReadLine();
    }
    else if (opcao == "4")
    {
        lampada.MostrarEstado();
    }
    else
    {
        Console.WriteLine("Digite uma opção válida!");
        Console.WriteLine("Digite 1 se você deseja ligar a lâmpada, 2 para desligar, 3 para mostrar o estado da lâmpada ou 4 para sair:");
        opcao = Console.ReadLine();
    }
}