using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesSis08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double alunosds = 0;
            double alunosedf = 0;
            double alunosmeca = 0;
            double alunosadm = 0;
            int resp = 1;


            while (resp == 1)
            {
                Console.WriteLine("Informe o curso que deseja matricular o aluno: " +
                    "DS{1}/Meca{2}/Meca{3}/ADM{4}");
                double tipo = double.Parse(Console.ReadLine());


                switch (tipo)
                {
                    case 1:
                        if (alunosds < 5)
                        {
                            Console.WriteLine("O aluno foi cadastrado. ");

                            alunosds++;
                        }
                        else 
                        {
                            Console.WriteLine("O curso já atingiu a quantidade limite de vagas.");
                        }
                        break;

                    case 2:
                        if (alunosedf < 5)
                        {
                            Console.WriteLine("O aluno foi cadastrado. ");
                            alunosedf++;
                        }
                        else
                        {
                            Console.WriteLine("O curso já atingiu a quantidade limite de vagas.");
                        }
                        break;



                    case 3:
                        if (alunosadm < 5)
                        {
                            Console.WriteLine("O aluno foi cadastrado. ");
                            alunosadm++;
                        }
                        else
                        {
                            Console.WriteLine("O curso já atingiu a quantidade limite de vagas.");
                        }
                        break;


                    case 4:
                        if (alunosmeca < 5)
                        {
                            Console.WriteLine("O aluno foi cadastrado. ");
                            alunosmeca++;
                        }
                        else
                        {
                            Console.WriteLine("O curso já atingiu a quantidade limite de vagas.");
                        }
                        break;
                }

                Console.WriteLine("Deseja cadastrar mais um? {sim=1/não=2}");
                resp = int.Parse(Console.ReadLine());
            }
            //coloque aqui embaixo os dados de quantos alunos cadastraram e em cada curso :
            Console.WriteLine("Quantidade de vagas preenchidas em DS: "+ alunosds + "de 5");
            Console.WriteLine("Quantidade de vagas preenchidas em edf: " + alunosedf + "de 5");
            Console.WriteLine("Quantidade de vagas preenchidas em adm: " + alunosadm + "de 5");
            Console.WriteLine("Quantidade de vagas preenchidas em meca: " + alunosmeca + "de 5");

            Console.ReadKey();
        }
    }
}

        
