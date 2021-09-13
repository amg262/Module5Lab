﻿using System;

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

            for (int i = 0; i < days.Length; i++)
            {
                Console.Write($"Enter sightings on {days[i]}: ");
                Int32.TryParse(Console.ReadLine(), out sightings[i]);
            }

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine($"{days[i]}:  {sightings[i]}");
                total += sightings[i];
            }

            mean = total / sightings.Length;
            median = total / 2;

            Console.WriteLine($"\nTotal:  {total:F}");
            Console.WriteLine($"Mean:  {mean:F}");
            Console.WriteLine($"Median:  {median:F}");

        }
        
        static void Main(string[] args)
        {
            TrackUFO();
        }
    }
}