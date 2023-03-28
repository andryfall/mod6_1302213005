using System;
using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Contract.Assert(title.Length < 200);
        Contract.Assert(title != null);
        Random rand = new Random();
        this.title = title;
        this.id = rand.Next();
        this.playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        Contract.Assert(playCount <= 25000000);
        Contract.Assert(playCount >= 0);
        try
        {
            checked
            {
                this.playCount += playCount;
            }
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);
        }
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
