using Course_Collections_Alura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            IDictionary<string, Aluno> alunos = new SortedDictionary<string, Aluno>();

            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 5617));
            alunos.Add("RN", new Aluno("Rafael", 17645));
            alunos.Add("WM", new Aluno("Wanderson", 11287));

            Imprimir(alunos);

            Console.ReadKey();
        }

        private static void Imprimir(IDictionary<string, Aluno> alunos)
        {
            Console.WriteLine("=====================================================================");
            foreach (var item in alunos)
            {
                Console.WriteLine(item);
            }
        }
    }
}
