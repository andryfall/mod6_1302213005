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
            v.IncreasePlayCount(40);
            u.AddVideo(v);
            v = new SayaTubeVideo("t3");
            u.AddVideo(v);
            v = new SayaTubeVideo("t4");
            u.AddVideo(v);
            v.IncreasePlayCount(23);
            v = new SayaTubeVideo("t5");
            u.AddVideo(v);
            v = new SayaTubeVideo("t6");
            u.AddVideo(v);
            v = new SayaTubeVideo("t7");
            u.AddVideo(v);
            v = new SayaTubeVideo("t8");
            u.AddVideo(v);

            Console.WriteLine("Total PlayCount : " + u.GetTotalVideoPlayCount());
            u.PrintAllVideoPlaycount();
        }
    }
}
