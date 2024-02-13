class Podcast
{
    public string Host { get; }
    public string Name { get; }
    private List<Episode> AllEpisodes = new();

    public Podcast(string host, string name)
    {
        this.Host = host;
        this.Name = name;
    }

    public void AddEpisode(Episode episode)
    {
        AllEpisodes.Add(episode);
    }

    public void ShowDetails()
    {
        Console.WriteLine($"{this.Name} - {this.Host}\n");

        foreach (Episode episode in AllEpisodes.OrderBy(e => e.Id))
        {
            Console.WriteLine($"Episode {episode.Id}: {episode.Title} - {episode.Duration / 60}");
        }

        Console.WriteLine($"Total Episodes: {AllEpisodes.Count}");
    }
}