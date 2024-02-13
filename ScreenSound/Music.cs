class Music
{
    public string name;
    public string artist;
    public double duration;
    public bool available;

    public Music(string name, string artist, double duration, bool available)
    {
        this.name = name;
        this.artist = artist;
        this.duration = duration;
        this.available = available;
    }

    public void ShowMusicInfo()
    {
        Console.WriteLine($"Music's Name: {this.name}");
        Console.WriteLine($"Music's Artist: {this.artist}");
        Console.WriteLine($"Music's Duration: {this.duration}");
        if (available) Console.WriteLine($"Music's Available: Disponível");
        else Console.WriteLine($"Music's Available: Não está disponível");
    }
} 