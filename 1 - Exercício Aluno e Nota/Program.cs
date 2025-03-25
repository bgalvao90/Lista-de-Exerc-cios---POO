using _1___Exercício_Aluno_e_Nota;

Aluno aluno = new Aluno();

aluno.ReceberDados();

Console.Clear();
Console.WriteLine($"RA: {aluno.RA}                     Nome do Aluno: {aluno.Nome}");

aluno.CalcularMedia();

aluno.ImprimirNotaFinal();

aluno.CalcularNotaFinal();

Console.ReadLine();