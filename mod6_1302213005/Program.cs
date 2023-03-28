namespace mod6_1302213005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser u = new SayaTubeUser("Andry");
            SayaTubeVideo v;
            v = new SayaTubeVideo("t1");
            u.AddVideo(v);
            v = new SayaTubeVideo("t2");
            u.AddVideo(v);
            v = new SayaTubeVideo("t3");
            u.AddVideo(v);
            v = new SayaTubeVideo("t4");
            u.AddVideo(v);

            Console.WriteLine(u.GetTotalVideoPlayCount());
            u.PrintAllVideoPlaycount();
        }
    }
}
