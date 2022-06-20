using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1b
{
    class Program
    {
        static void Main(string[] args)
        {
            escolhi aluno;
            aluno = new escolhi();
            escolhi professor = new escolhi();
            aluno.nome = "rafael";
            professor.nome = "prof.jefersinho";
            Console.WriteLine("aluno:" + aluno.nome);
            Console.WriteLine("professor:" + professor.nome);
            Console.ReadKey();
        }
    }
}
