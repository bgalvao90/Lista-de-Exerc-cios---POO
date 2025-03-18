using _2___Exercício_Criando_um_sistema_de_Conta_Bancária;

ContaBancaria conta = new ContaBancaria();

Console.WriteLine("Digite o número da conta: ");
conta.NumeroConta = Console.ReadLine().ToUpper();
Console.WriteLine("Digite o nome do titular: ");
conta.Titular = Console.ReadLine().ToUpper();
conta.Saldo = 0;

Console.Clear();
Console.WriteLine($" Número da conta: {conta.NumeroConta}                     Nome do Titular: {conta.Titular}");
Console.WriteLine("Digite depositar, sacar, exibir saldo ou sair ");
string opcao = Console.ReadLine().ToUpper(); ;

do
{

    if (opcao == "DEPOSITAR")
    {
        Console.Clear();
        Console.WriteLine($" Número da conta: {conta.NumeroConta}                     Nome do Titular: {conta.Titular}");
        Console.WriteLine("Digite o valor a ser depositado: ");
        double valor = double.Parse(Console.ReadLine());
        conta.Depositar(valor);
        Console.Clear();
        Console.WriteLine($" Número da conta: {conta.NumeroConta}                     Nome do Titular: {conta.Titular}");
        Console.WriteLine("Digite depositar, sacar, exibir saldo ou sair ");
        opcao = Console.ReadLine().ToUpper();

    }
    else if (opcao == "SACAR")
    {
        Console.Clear();
        Console.WriteLine($" Número da conta: {conta.NumeroConta}                     Nome do Titular: {conta.Titular}");
        Console.WriteLine("Digite o valor a ser sacado: ");
        double valor = double.Parse(Console.ReadLine());
        conta.Sacar(valor);
        Console.Clear();
        Console.WriteLine($" Número da conta: {conta.NumeroConta}                     Nome do Titular: {conta.Titular}");
        Console.WriteLine("Digite depositar, sacar, exibir saldo ou sair ");
        opcao = Console.ReadLine().ToUpper();
    }
    else if (opcao == "EXIBIR SALDO")
    {
        Console.Clear();
        Console.WriteLine($" Número da conta: {conta.NumeroConta}                     Nome do Titular: {conta.Titular}");
        conta.ExibirSaldo();
        Console.WriteLine("Digite depositar, sacar, exibir saldo ou sair ");
        opcao = Console.ReadLine().ToUpper();
    }
    else if(opcao == "SAIR")
    {
        Console.WriteLine("Obrigado por utilizar nossos serviços");
    }
    else
    {
        Console.WriteLine("Opção inválida");
        Console.WriteLine("Digite depositar, sacar, exibir saldo ou sair ");
        opcao = Console.ReadLine().ToUpper();
    }

} while (opcao != "SAIR");