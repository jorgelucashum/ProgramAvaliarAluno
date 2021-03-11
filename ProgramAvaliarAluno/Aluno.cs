using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAvaliarAluno
{
    class Aluno
    {
        public string Nome;
        public double N1, N2, N3;

        public double NotaFinal()
        {
            double notaF = N1 + N2 + N3;
            return notaF;   
        }

        public bool Aprovacao()
        {
            if (NotaFinal() >= 60)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovacao())
            {
                return 0;
            } else
            {
                return 60 - NotaFinal();
            }
           

        }
    }
}
