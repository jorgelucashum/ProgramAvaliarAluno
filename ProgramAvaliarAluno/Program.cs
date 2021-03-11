using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAvaliarAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite seu nome: ");
            aluno.Nome = Console.ReadLine();

            do
            {
                Console.WriteLine("Digite a nota do primeiro trimestre (max: 30) ");
                aluno.N1 = double.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (aluno.N1 > 30);

            do
            {
                Console.WriteLine("Digite a nota do segundo trimestre (max: 35) ");
                aluno.N2 = double.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (aluno.N2 > 35);

            do
            {
                Console.WriteLine("Digite a nota do terceiro trimestre: (max: 35)");
                aluno.N3 = double.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (aluno.N3 > 35);


            Console.WriteLine(aluno.Nome);
            if (aluno.Aprovacao())
            {
                Console.WriteLine("Nota final: " + aluno.NotaFinal().ToString("F2") + "\nAPROVADO");
            } else
            {
                Console.WriteLine("Nota Final: " + aluno.NotaFinal().ToString("F2") + "\nREPROVADO \nFaltaram: " + aluno.NotaRestante().ToString("F2"));
            }


            Console.ReadLine();

        }
    }
}
