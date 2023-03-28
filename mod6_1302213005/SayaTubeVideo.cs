using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random rand = new Random();
        this.title = title;
        this.id = rand.Next();
        this.playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        this.playCount += playCount;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Title Video : " + this.title);
        Console.WriteLine("Id Video : " + this.id);
        Console.WriteLine("PlayCount Video : " + this.playCount);
    }

    public int getPlayCount()
    {
        return this.playCount;
    }

    public string getTitle()
    {
        return this.title;
    }
}
