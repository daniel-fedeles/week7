namespace DownloadImage
{
    class Program
    {
        static void Main(string[] args)
        {
            DownloadFromUrl dow = new DownloadFromUrl();
            dow.DownloadImg("https://qazjapan.com/cms/wp-content/uploads/2019/04/img_ninja_232104394.jpg", "img_ninja_232104394.jpg");
        }
    }
}
