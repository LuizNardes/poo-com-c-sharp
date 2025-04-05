class Musica {

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; set; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set;}
    public string Descricao => $"A música {Nome} pertence a banda {Artista.Nome}.";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }else
        {
            Console.WriteLine("Adquira o plano PlusUltra");
        }
        System.Console.WriteLine(Descricao);
    }
}

