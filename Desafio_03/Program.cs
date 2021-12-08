using System;

namespace Desafio_03
{
    class Program
    {
        public class Aluno
        {
            public string Nome;
            public int Nota;
        }
        static void Main(string[] args)
        {
            int quant;
            Aluno MaiorAluno = new Aluno();
            MaiorAluno.Nota = 0;
            Console.WriteLine($"Informe a quantidade de alunos:");
            quant = int.Parse(Console.ReadLine());
            Aluno aluno = new Aluno();
            
            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine($"Informe o nome do aluno:");
                aluno.Nome = Console.ReadLine();

                Console.WriteLine($"Informe a nota do aluno:");
                aluno.Nota = int.Parse(Console.ReadLine());

                if (MaiorAluno.Nota < aluno.Nota)
                {
                    MaiorAluno = aluno;
                }
                
            }
           
            Console.WriteLine($"Aluno com maior nota:{aluno.Nome} e sua nota é: {aluno.Nota}");
        }


    }
}

