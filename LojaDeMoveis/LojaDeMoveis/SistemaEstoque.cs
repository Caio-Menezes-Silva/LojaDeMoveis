using System;
using System.Globalization;
using System.Runtime.CompilerServices;
namespace LojaDeMoveis
{
    internal class SistemaEstoque
    {

        private string _produto;

        public string Produto
        {
            get { return _produto; }

            set
            {
                if (_produto == null || _produto.Length < 3)
                {
                    Console.WriteLine("Produto inexistente.");
                }
            }
        }

        private double _preco { get; set; }

        private double _quantidade { get; set; }
        public void AdicionarEstoque()
        {   
            Console.WriteLine("Digite o nome do produto a ser adicionado:");
            _produto = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto a ser adicionado:");
            _preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Agora digite a quantidade:");
            _quantidade = int.Parse(Console.ReadLine());
        }

        public void RemoverEstoque()
        {
            _preco -= _preco * _quantidade;
            _quantidade -= _quantidade;

            Console.WriteLine("Digite a quantidade que deseja remover:");
            _quantidade = int.Parse(Console.ReadLine());
        }



        public double ValorTotal()
        {
            double precoTotal = _preco * _quantidade;
            return precoTotal;
        }

        public override string ToString()
        {
            return "Produto: " + _produto + ", " + "R$" + ValorTotal().ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade + " em estoque";
        }
    }
}
