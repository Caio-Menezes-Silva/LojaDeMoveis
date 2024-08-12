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
                " \n1- Consultar estoque \n2- Adicionar ao estoque \n3- Remover do estoque \n4- Repeitr. \n5- Encerrar");

            int açao = int.Parse(Console.ReadLine());
            do
            {
                switch (açao)
                {
                    case 1:
                        Console.WriteLine(est.ToString());
                        break;

                    case 2:
                        Console.WriteLine("Digite o nome do produto a ser adicionado:");
                        string produto = Console.ReadLine();
                        Console.WriteLine("Digite o preço do produto a ser adicionado:");
                        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.WriteLine("Agora digite a quantidade:");
                        int qtd = int.Parse(Console.ReadLine());
                        break;

                    case 3:
                        break;

                    case 4:
                        break;
                }
                Console.WriteLine("Digite o número referente a ação que será feita:" +
                    " \n1- Consultar estoque \n2- Adicionar ao estoque \n3- Remover do estoque \n4- Repeitr. \n5- Encerrar");
                açao = int.Parse(Console.ReadLine());
            } while (açao != 5);






            Console.ReadKey();
        }
    }
}