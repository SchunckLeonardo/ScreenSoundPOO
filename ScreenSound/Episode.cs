class Episode
{
    public int Duration { get; }
    public int Id { get; }
    public string Resume => $"{this.Id}. {this.Title} ({this.Duration / 60} min) - {string.Join(", ", guests)}";
    public string Title { get; }
    private List<string> guests = new();

    public Episode(string Title, int Duration, int Id)
    {
        this.Title = Title;
        this.Duration = Duration;
        this.Id = Id;
    }

    public void AddGuest(string guest)
    {
        guests.Add(guest);
    }

}
