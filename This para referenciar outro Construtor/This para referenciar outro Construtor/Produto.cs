using System;

class Produto
{
    public string nome;
    public double preco;
    public int quantidade;

    // Construtor 1: sem parâmetros
    public Produto()
    {
        quantidade = 10;
        Console.WriteLine("Construtor Produto() chamado: quantidade = 10");
    }

    // Construtor 2: nome e preço
    public Produto(string nome, double preco) : this()
    {
        this.nome = nome;
        this.preco = preco;
        Console.WriteLine($"Construtor Produto(nome, preco) chamado: nome = {nome}, preco = {preco}");
    }

    // Construtor 3: nome, preço e quantidade
    public Produto(string nome, double preco, int quantidade) : this(nome, preco)
    {
        this.quantidade = quantidade;
        Console.WriteLine($"Construtor Produto(nome, preco, quantidade) chamado: quantidade = {quantidade}");
    }

    public override string ToString()
    {
        return $"Produto: {nome}, Preço: {preco}, Quantidade: {quantidade}";
    }
}


