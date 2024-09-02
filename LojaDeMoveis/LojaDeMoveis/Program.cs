using LojaDeMoveis;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq.Expressions;

namespace Menu_Loja_Moveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  ////////////////////////////////////////" +
                            "\n ///////////// LOJA DE MOVEIS ///////////" +
                            "\n////////////////////////////////////////");
            Console.WriteLine(); /// LINHA PULADA ///

            Console.WriteLine("Olá vendedor, já é possui cadastro? (S/N)");
            string resp = Console.ReadLine().ToUpper();

            SistemaDeLogin log = new SistemaDeLogin();
            if (resp != null || resp == "s")
            {
                Console.WriteLine("Digite sua matrícula:");
            }
            else { Console.WriteLine("Entre em contato com o setor de T.i para realizar seu cadastro no sistema."); }
         
            Console.Write("Matrícula: ");
            log.RegistrationNumber = Console.ReadLine();

            Console.Write("Senha: ");
            log.Password = Console.ReadLine();

            Console.WriteLine(); /// LINHA PULADA ///

            SistemaEstoque est = new SistemaEstoque();

            Console.WriteLine("Digite o número referente a ação que será feita:" +
                " \n1- Consultar estoque" +
                " \n2- Adicionar ao estoque" +
                " \n3- Remover do estoque" +
                " \n4- Encerrar.");

            int açao = int.Parse(Console.ReadLine());
            do
            {
                switch (açao)
                {
                    case 1:
                        Console.WriteLine(est.ToString());
                        break;

                    case 2:
                        est.AdicionarEstoque();
                        break;
                    case 3:
                        est.RemoverEstoque();
                        break;
                }
               
                Console.WriteLine("Digite o número referente a ação que será feita:" +
                    " \n1- Consultar estoque" +
                    " \n2- Adicionar ao estoque" +
                    " \n3- Remover do estoque" +
                    " \n4- Encerrar");
                açao = int.Parse(Console.ReadLine());
                

            } while (açao != 4);
            Console.WriteLine("Obrigado por utilizar nosso sistema");


            Console.ReadKey();
        }
    }
}