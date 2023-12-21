using System;
namespace AntColony
{
    public static class GraphMaker
    {
        static Random random = new Random();
        public static int[][] MakeGraphDistances(int countCities)
        {
            int[][] dists = new int[countCities][];
            for (int i = 0; i < dists.Length; i++)
            {
                dists[i] = new int[countCities];
            }
            for (int i = 0; i <= countCities - 1; i++)
            {
                for (int j = i + 1; j <= countCities - 1; j++)
                {
                    int length = random.Next(1, 9);
                    dists[i][j] = length;
                    dists[j][i] = length;
                }
            }
            return dists;
        }
    }
}
