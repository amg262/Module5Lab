using System;
using System.Linq;

namespace Module5Lab
{
    class Program
    {
        static void TrackUFO()
        {
            string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};
            int[] sightings = new int[5];
            int total = 0;
            double mean = 0;
            double median = 0;
            int past = 0;
            int least = 0;
            int curr = 0;
            int most = 0;
            int j = 0;
            for (int i = 0; i < days.Length; i++)
            {
                Console.Write($"Enter sightings on {days[i]}: ");
                Int32.TryParse(Console.ReadLine(), out sightings[i]);
            }

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine($"{days[i]}:  {sightings[i]}");
            }

            Console.WriteLine($"\nTotal:  {sightings.Sum()}");
            Console.WriteLine($"Mean:  {sightings.Sum() / (double) sightings.Length}");
            Console.WriteLine($"Median:  {(double) sightings.Sum() / 2}");
            Console.WriteLine($"Lowest:  {sightings.Min()}");
            Console.WriteLine($"Highest:  {sightings.Max()}");
            Console.WriteLine($"Range:  {sightings.Max() - sightings.Min()}");
        }

        static void Main(string[] args)
        {
            TrackUFO();
        }
    }
}