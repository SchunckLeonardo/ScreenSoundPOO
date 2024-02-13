Band brunoMars = new("Bruno Mars");

Album unorthodoxJukebox = new("Unorthodox Jukebox");
Album dooWops = new("Doo-Wops & Hooligans");

Music music1 = new("When I Was Your Man", brunoMars, 200);
Music music2 = new("Locked Out Of Heaven", brunoMars, 212);

Music music3 = new("Grenade", brunoMars, 205);
Music music4 = new("Just The Way You Are", brunoMars, 204);

unorthodoxJukebox.AddMusic(music1);
unorthodoxJukebox.AddMusic(music2);

dooWops.AddMusic(music3);
dooWops.AddMusic(music4);

brunoMars.AddAlbum(unorthodoxJukebox);
brunoMars.AddAlbum(dooWops);

dooWops.ShowAlbum();
unorthodoxJukebox.ShowAlbum();

brunoMars.ShowDiscography();