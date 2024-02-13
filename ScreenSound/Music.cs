class Music
{
    public string Name { get; set; }
    public string Artist { get; set; }
    public double Duration { get; set; }
    public bool Available { get; set; }
    public string NameArtist => $"{this.Name} by {this.Artist}";

    public Music(string name, string artist, double duration)
    {
        this.Name = name;
        this.Artist = artist;
        this.Duration = duration;
    }

    public void ShowMusicInfo()
    {
        Console.WriteLine($"Music's Name: {this.Name}");
        Console.WriteLine($"Music's Artist: {this.Artist}");
        Console.WriteLine($"Music's Duration: {this.Duration}");
        if (Available) Console.WriteLine($"Music's Available: Disponível");
        else Console.WriteLine($"Music's Available: Não está disponível");
    }
} 