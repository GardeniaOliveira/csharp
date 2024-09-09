class Music
{
    //propriets = when have get and set
    public string Title { get; set; }
    public string Artist { get; set; }
    public  int Duration { get; set; }
    public bool Available { get; set; }

    //i only what read, so i use only get
    public string Description {
        get
        {
            return $"The music {Title} belong to the band {Artist}";
        }
    }

    //another way to write the code 
    //public string Description => $"The music {Title} belong to the band {Artist}";


    //method
    public void ShowMusicInfo()
    {
        Console.WriteLine($"Title : {Title}");
        Console.WriteLine($"Artist : {Artist}");
        Console.WriteLine($"Duration : {Duration}");
     
        if (Available)
        {
            Console.WriteLine("It is available in your plan");
        }
        else
        {
            Console.WriteLine("Upgrade your plan to plus+");
        }
    }
}