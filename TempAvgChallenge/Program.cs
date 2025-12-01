namespace TempAvgChallenge;

public class Program
    {
        public void PrintAverage(double[] temperatures)
        { 
            double avgTemp = CalculateAverage(temperatures);

            Console.WriteLine($"The average temperature is: {avgTemp}");
        }

        public double CalculateAverage(double[] temperatures)
        {
            int count = 0;
            double totalTemps = 0;

            foreach (double i in temperatures)
            {
                totalTemps = totalTemps + i;
                count++;
            }

            double avgTemp = 0;

            return  avgTemp = totalTemps / count;
        }
    }