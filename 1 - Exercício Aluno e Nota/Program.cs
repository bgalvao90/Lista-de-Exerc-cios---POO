using _1___Exercício_Aluno_e_Nota;

Aluno aluno = new Aluno();

Console.WriteLine("Digite o RA do aluno: ");
aluno.RA = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o nome do aluno: ");
aluno.Nome = Console.ReadLine();

Console.WriteLine("Digite a nota da prova: ");
aluno.NotaDaProva = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota do trabalho: ");
aluno.NotaDoTrabalho = double.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine($"RA: {aluno.RA}                     Nome do Aluno: {aluno.Nome}");

aluno.CalcularMedia();

aluno.ImprimirNotaFinal();

aluno.CalcularNotaFinal();

Console.ReadLine();