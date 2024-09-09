Music music1 = new Music();
music1.Title = "Roxanne";
music1.Artist = "The police";
music1.Duration = 60;
music1.Available =true;

Console.WriteLine(music1.Description);
music1.ShowMusicInfo();

Console.WriteLine("***************************");
Music music2 = new Music();
music2.Title = "A lua me traiu";
music2.Artist = "Calypso";
music2.Duration = 120;
music2.Available = false;

Console.WriteLine(music2.Description);
music2.ShowMusicInfo();