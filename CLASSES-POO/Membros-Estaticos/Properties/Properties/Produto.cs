﻿using System.Globalization;
namespace Course
{
    class Produto
    {
        // atributos + propertie
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        // construtor
        public Produto(string nome, double preco, int quantidade)
        {  
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        // propertie nome com logica de verificacao
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
       
        // metodos da classe
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}