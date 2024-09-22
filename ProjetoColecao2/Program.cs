using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoColecao2.Entites;

namespace ProjetoColecao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HashSet<Studant> set = new HashSet<Studant>();
                Console.Write("Quantos alunos matriculados no curso A: ");
                int N = int.Parse(Console.ReadLine());
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine("Digite ID: ");
                    int id = int.Parse(Console.ReadLine());
                    set.Add(new Studant(id));
                    Console.WriteLine();
                }
                Console.Write("Quantos alunos matriculados no curso B: ");
                N = int.Parse(Console.ReadLine());
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine("Digite ID: ");
                    int id = int.Parse(Console.ReadLine());
                    set.Add(new Studant(id));
                    Console.WriteLine();
                }
                Console.Write("Quantos alunos matriculados no curso C: ");
                N = int.Parse(Console.ReadLine());
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine("Digite ID: ");
                    int id = int.Parse(Console.ReadLine());
                    set.Add(new Studant(id));
                    Console.WriteLine();
                }
                Console.WriteLine("Total de estudante matriculados nos cursos: " + set.Count);
              
            }
            catch (StudantException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
