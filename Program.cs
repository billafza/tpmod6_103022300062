using System.Diagnostics;

class SayaTubeVideo
{
    int id;
    String title;
    int playCount;

    public SayaTubeVideo(String title)
    {

        Debug.Assert(title.Length <= 100, "Judul maksimal 100 karakter!");
        Debug.Assert(title != null, "Judul tidak boleh kosong!");

        Random rdmId = new Random();
        this.id = rdmId.Next(00001, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void increasePlayCount(int playCount)
    {
        try
        {
            if (playCount < 0 || playCount > 10000000)
            {
                throw new ArgumentException("Error : Input Play Count minimal 0 dan maksomal 10.000.000");
            }

            checked
            {
                this.playCount += playCount;
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
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
        video.increasePlayCount(17000000);
        video.increasePlayCount(-10);
        video.increasePlayCount(100000);
        video.printVideoDetails();
    }
}