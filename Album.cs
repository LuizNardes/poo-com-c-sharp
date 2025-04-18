class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        System.Console.WriteLine($"Músicas do album {Nome}");
        foreach (var musica in musicas)
        {
            System.Console.WriteLine($"Música: {musica.Nome}");
        }
        System.Console.WriteLine($"Duração total do album: {DuracaoTotal}");
    }
}