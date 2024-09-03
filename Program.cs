int anoNasc1, anoNasc2, idade1, idade2, anoAtual = 2024;
string nome1, nome2;

Console.WriteLine("--- Calculo e Comparação de Idades ---\n");


Console.WriteLine("Primeira Pessoa");
Console.WriteLine("Digite seu nome: ");
nome1 = Console.ReadLine()!;
Console.WriteLine($"Olá {nome1}, informe seu ano de nascimento: ");
anoNasc1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Que legal {nome1}, Você nasceu em {anoNasc1}");
idade1 = anoAtual - anoNasc1;

Console.WriteLine("\nSegunda Pessoa");
Console.WriteLine("Digite seu nome: ");
nome2 = Console.ReadLine()!;
Console.WriteLine($"Olá {nome2}, informe seu ano de nascimento: ");
anoNasc2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Que legal {nome2}, Você nasceu em {anoNasc2}");

idade2 = anoAtual - anoNasc2;

if (idade1 < idade2)
{
    Console.WriteLine($"{nome1} é mais novo(a)");
}
else if (idade2 < idade1)
{
    Console.WriteLine($"{nome2} é mais novo(a)");
}
else
{
    Console.WriteLine("As duas pessoas tem a mesma idade");
}
