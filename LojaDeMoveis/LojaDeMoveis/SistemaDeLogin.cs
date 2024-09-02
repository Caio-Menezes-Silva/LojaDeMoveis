using System;
using System.Globalization;
namespace LojaDeMoveis
{
    internal class SistemaDeLogin
    {
        private string _regNumber;
        private string _password;
        public string RegistrationNumber
        {
            get { return _regNumber; }

            set
            {
                if (_regNumber == null && value.Length != 6)
                {
                    Console.WriteLine("Login inválido. Tente novamente.");
                }
            }
        }

        public string PergInit() {
            string resp = Console.ReadLine().ToUpper();

            if (resp != null || resp == "s")
            {
                Console.WriteLine("Digite sua matrícula:");
            }
            else { Console.WriteLine("Entre em contato com o setor de T.i para realizar seu cadastro no sistema."); }

            Console.Write("Matrícula: ");
            RegistrationNumber = Console.ReadLine();

            Console.Write("Senha: ");
            Password = Console.ReadLine();

            return resp;
        }


        public string Password
        {
            get { return _password; }
            set
            {
                if (_password == null && value.Length < 8)
                {
                    Console.WriteLine("Senha inválida. Tente novamente.");
                }
                else { Console.WriteLine("Olá vendedor, bem vindo!"); }
            }
        }
    }
}
