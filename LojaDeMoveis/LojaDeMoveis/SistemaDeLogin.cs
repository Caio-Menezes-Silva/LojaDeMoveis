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
