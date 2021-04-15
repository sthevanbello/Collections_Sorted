using Course_Collections_Alura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {

            IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();

            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 5617));
            alunos.Add("RN", new Aluno("Rafael", 17645));
            alunos.Add("WM", new Aluno("Wanderson", 11287));

            Imprimir(alunos);

            alunos.Remove("AL");

            Imprimir(alunos);

            alunos.Add("MO", new Aluno("Marcelo", 12345));

            Imprimir(alunos);

            IDictionary<string, Aluno> sortedAlunos = new SortedList<string, Aluno>();
            sortedAlunos.Add("VT", new Aluno("Vanessa", 34672));
            sortedAlunos.Add("AL", new Aluno("Ana", 5617));
            sortedAlunos.Add("RN", new Aluno("Rafael", 17645));
            sortedAlunos.Add("WM", new Aluno("Wanderson", 11287));

            Console.WriteLine($"\nSortedList\n");

            Imprimir(sortedAlunos);



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
