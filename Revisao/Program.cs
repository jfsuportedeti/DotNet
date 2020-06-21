using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUser = obterOpcaoUser();

            while (opcaoUser.ToUpper() != "X")
            {
                switch (opcaoUser)
                {
                    case "1":
                        //TODO Adicionar alunos
                        Console.WriteLine("Você escolheu 1");
                        break;
                    case "2":
                        //TODO Listar alunos
                        Console.WriteLine("Você escolheu 2");
                        break;
                    case "3":
                        //TODO cALCULAR MEDIA
                        Console.WriteLine("Você escolheu 3");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
               opcaoUser = obterOpcaoUser();
            }
        }

        private static string obterOpcaoUser()
        {
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1 - Inserir Novo Aluno");
            Console.WriteLine("2 - Listar Aluno");
            Console.WriteLine("3 - Calcular Media Geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine("****************************");
            string opcaoUser = Console.ReadLine();
            return opcaoUser;
        }
    }
}
