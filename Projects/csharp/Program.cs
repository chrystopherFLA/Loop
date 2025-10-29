using System.Globalization;

namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Defina quantos alunos ha na turma: ");
        int tamanho = int.Parse(Console.ReadLine());

        double[] notas = new double[tamanho];

        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine("Digite a nota do aluno " + (i + 1) + ":");
            notas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        double soma = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine("Nota do Aluno " + (i + 1) + ": " + notas[i]);
            soma += notas[i];
        }

        double media = soma / notas.Length;
        Console.WriteLine("Media das notas na turma é: " + media);

    }
}
