using System;

namespace TheaThePhotographer
{
    public class TheaThePhotographer
    {
        public static void Main()
        {
            int pictures = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            long overallFilterTime = (long)pictures * filterTime;
            long filteredPictures = (long)Math.Ceiling((double)pictures * filterFactor /100);
            long overallUploadTIme = filteredPictures * uploadTime;
            long totalTime = overallFilterTime + overallUploadTIme;

            TimeSpan timeSpan = TimeSpan.FromSeconds(totalTime);

            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                timeSpan.Days,
                timeSpan.Hours,
                timeSpan.Minutes,
                timeSpan.Seconds);
        }
    }
}
