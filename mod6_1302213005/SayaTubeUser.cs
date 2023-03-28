using System;

public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string username;

    public SayaTubeUser(string username)
    {
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
        uploadedVideos.Add(video);
    }
    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine("User : " + this.username);
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            Console.WriteLine("Video " + (i + 1) + " judul: " + uploadedVideos[i].getTitle());
        }
    }
}

