using JurnalMOD6_1302210025;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeUser tube = new SayaTubeUser("Tangguh Laksana");
        SayaTubeVideo v = new SayaTubeVideo("Review Film Harry Potter oleh Tangguh Laksana ");
        tube.addVideo(v);
        v = new SayaTubeVideo("Review Film UltraMan oleh Tangguh Laksana ");
        tube.addVideo(v);
        v = new SayaTubeVideo("Review Film Ultra Milk oleh Tangguh Laksana ");
        tube.addVideo(v);
        v = new SayaTubeVideo("Review Film SpiderMan oleh Tangguh Laksana ");
        tube.addVideo(v);
        v = new SayaTubeVideo("Review Film Inuyasha oleh Tangguh Laksana ");
        tube.addVideo(v);
        v = new SayaTubeVideo("Review Film Naruto oleh Tangguh Laksana ");
        tube.addVideo(v);
        v = new SayaTubeVideo("Review Film GodOfWar oleh Tangguh Laksana ");
        tube.addVideo(v);
        v = new SayaTubeVideo("Review Film KKN Desa Penari oleh Tangguh Laksana ");
        tube.addVideo(v);
        v = new SayaTubeVideo("Review Film HowToBasic oleh Tangguh Laksana ");
        tube.addVideo(v);
        v = new SayaTubeVideo("Review Film L oleh Tangguh Laksana ");
        v.increasePlayCount(-26000000);
        tube.addVideo(v);

       
        tube.printAllVideoPlayCount();
    }
}