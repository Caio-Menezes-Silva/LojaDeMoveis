using System;
using System.Globalization;
using System.Runtime.CompilerServices;
namespace LojaDeMoveis
{
    internal class SistemaEstoque
    {
        private string _produto
        {
            get { return _produto; }
            set
            {
                if (_produto == null)
                {
                    Console.WriteLine("Produto inexistente");
                }

            }
        }

        private double _preco { get; set; }

        private double _quantidade;

        public void Estoque(double preco, int qtd, string produto)
        {
            _preco = preco;
            _quantidade = qtd;
            _produto = produto;
        }


        public void AdicionarEstoque(double preco, int qtd, string produto)
        {
            _preco += preco;
            _quantidade += qtd;
            _produto += produto;
        }

        public void RemoverEstoque(double preco, int qtd)
        {
            _preco -= preco;
            _quantidade -= qtd;

        }

        public double ValorTotal()
        {
            double precoTotal = _preco * _quantidade;
            return precoTotal;
        }
        
        public override string ToString()
        {
            return "Produto: " + _produto + ", " + "R$" + ValorTotal().ToString("F2") + ", " + _quantidade +" em estoque";
        }
    }
}
