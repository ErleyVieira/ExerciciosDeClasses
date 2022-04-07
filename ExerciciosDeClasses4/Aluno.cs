using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeClasses4
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;


        public double Media()
        {
            double resultado = (Nota1 + Nota2 + Nota3);
            
                return resultado;
            
        }
        public string Aprovacao()
        {
            double resultado = Nota1 + Nota2 + Nota3;
            if (resultado > 60)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }
        public string PontosFaltantes()
        {
            double resultado = Nota1 + Nota2 + Nota3;
            if (resultado < 60)
            {
                return "faltaram " + (60 - resultado) + " pontos";
            }
            else
            {
                return null;
            }
        }
        
    }
}
