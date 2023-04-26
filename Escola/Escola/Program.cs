using Escola;
using System;
class Programa
{
    static void Main(string[] args)
    {
        Curso curso = new Curso { Nome = "Engenharia de Software", Codigo = "ES01" };
        List<Nota> notas = new List<Nota> {
            new Nota { Nome = "NP1", Valor = 7.5 },
            new Nota { Nome = "NP2", Valor = 8.2 },
            new Nota { Nome = "PIM", Valor = 9.0 }
        };
        Aluno aluno = new Aluno { Nome = "João", Matricula = "123456", Curso = curso, Notas = notas };
        Console.WriteLine($"Aluno: {aluno.Nome}\nMatrícula: {aluno.Matricula}\nCurso: {aluno.Curso.Nome} ({aluno.Curso.Codigo})");
        Console.WriteLine("Notas:");
        foreach (Nota nota in aluno.Notas)
        {
            Console.WriteLine($"{nota.Nome}: {nota.Valor}");
        }

        double media = Secretaria.CalcularMedia(aluno);
        Console.WriteLine($"A média do aluno {aluno.Nome} é {media}");

    }
}
