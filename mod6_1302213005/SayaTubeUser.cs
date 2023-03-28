using System;
using System.Diagnostics.Contracts;

public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string username;

    public SayaTubeUser(string username)
    {
        Contract.Assert(username.Length < 200);
        Contract.Assert(username != null);
        Random rand = new Random();
        this.username = username;
        this.id = rand.Next();
        uploadedVideos = new List<SayaTubeVideo>();

    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            total += uploadedVideos[i].getPlayCount();
        }

        return total;
    }

    public void AddVideo(SayaTubeVideo video)
    {
        Contract.Assert(video != null);
        Contract.Assert(video.getPlayCount() < int.MaxValue);

        uploadedVideos.Add(video);
    }
    public void PrintAllVideoPlaycount()
    {
        int i = 0;
        Console.WriteLine("User : " + this.username);
        for (i = 0; i < uploadedVideos.Count; i++)
        {
            Console.WriteLine("Video " + (i + 1) + " judul: " + uploadedVideos[i].getTitle());
        }

        Contract.Ensures(i <= 8);
    }
}

