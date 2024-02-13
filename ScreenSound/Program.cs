Podcast leocodelab = new("Leonardo", "Leocodelab");

Episode episode1 = new("C# é difícil?", 3600, 2);
Episode episode2 = new("O que é POO?", 4200, 1);

episode1.AddGuest("Leocodelab");
episode1.AddGuest("Mano Deyvin");

leocodelab.AddEpisode(episode1);
leocodelab.AddEpisode(episode2);

Console.WriteLine(episode1.Resume);

leocodelab.ShowDetails();