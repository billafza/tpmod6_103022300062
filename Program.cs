class SayaTubeVideo
{
    int id;
    String title;
    int playCount;

    public SayaTubeVideo(String title)
    {
        Random rdmId = new Random();
        this.id = rdmId.Next(00001, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void increasePlayCount(int playCount)
    {
        if (playCount < 0)
        {
            Console.WriteLine("Jumlah tidak boleh negatif!");
        }
        this.playCount += playCount;
    }

    public void printVideoDetails()
    {
        Console.WriteLine("ID: " + this.id);
        Console.WriteLine("Judul Video: " + this.title);
        Console.WriteLine("Jumlah Tayangan: " + this.playCount);
    }
}

class program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Nashbilla Nurfazza");
        video.increasePlayCount(17);
        video.printVideoDetails();
    }
}