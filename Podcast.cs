class Podcast
{
    private List<Episodio> episodios = new();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalEps => episodios.Count();

    public void AddEp(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        System.Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");

        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            System.Console.WriteLine(episodio.Resumo);
        }
        
        System.Console.WriteLine($"\n\nEsse podcast possui {TotalEps} episódios.");
    }
}