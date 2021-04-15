using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            ISet<string> alunos = new SortedSet<string>(new ComparadorMinusculo())
            {
                "Vanessa Tonini",
                "Ana Losnak",
                "Rafael Nercessian",
                "Priscila Stuani"
            };


            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");
            alunos.Add("FABIO GUSHIKEN");

            
            Console.WriteLine("\nSortedSet");
            Imprimir(alunos);

            ISet<string> outroConjunto = new HashSet<string>();

            var teste1 = alunos.IsSubsetOf(outroConjunto);
            var teste2 = alunos.IsSupersetOf(outroConjunto);
            var teste3 = alunos.SetEquals(outroConjunto);
            alunos.ExceptWith(outroConjunto);
            alunos.IntersectWith(outroConjunto);
            alunos.SymmetricExceptWith(outroConjunto);
            alunos.UnionWith(outroConjunto);



            Console.ReadKey();
        }

        private static void Imprimir(ISet<string> alunos)
        {
            Console.WriteLine("===========================");
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

        }
    }
}
