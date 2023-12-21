using System;

namespace AntColony
{
    public class Ant
    {
        public int[] path_ { get; private set; }
        public static int Alpha { get; set; }
        public static int Beta { get; set; }   

        Random random = new Random();
        public Ant(int[] path)
        {
            path_ = path;
        }

        public void CreatePath(int startCity, double[][] pheromones, int[][] dists)
        {
            path_ = new int[path_.Length];
            bool[] visitedCities = new bool[path_.Length];
            path_[0] = startCity;
            visitedCities[startCity] = true;
            for (int i = 0; i < path_.Length - 1; i++)
            {
                int cityX = path_[i];
                int nextCity = SelectNextCity(cityX, visitedCities,pheromones,dists);
                path_[i + 1] = nextCity;
                visitedCities[nextCity] = true;
            }
        }

        private int SelectNextCity(int cityX, bool[] visited, double[][] pheromones, int[][] dists)
        {
            double[] transitionProbability = CalculateTransitionProbability(cityX, visited, pheromones,dists);

            double[] probabilityScale = new double[transitionProbability.Length + 1];
            for (int i = 0; i < transitionProbability.Length; i++)
            {
                probabilityScale[i + 1] = probabilityScale[i] + transitionProbability[i];
            }

            double p = random.NextDouble();

            for (int i = 0; i < probabilityScale.Length - 1; i++)
            {
                if (p >= probabilityScale[i] && p < probabilityScale[i + 1])
                {
                    return i;
                }
            }

            throw new Exception("Failure to return valid city in NextCity");
        }

        private double[] CalculateTransitionProbability(int cityX, bool[] visited, double[][] pheromones, int[][] dists)
        {
            double[] cityWeight = new double[path_.Length];
            double sumCitiesWeight = 0.0;
            for (int i = 0; i <= cityWeight.Length - 1; i++)
            {
                if (i == cityX || visited[i] == true)
                {
                    cityWeight[i] = 0.0;
                }
                else
                {
                    cityWeight[i] = Math.Pow(pheromones[cityX][i], Alpha) * Math.Pow(1.0 / dists[cityX][i], Beta);
                    if (cityWeight[i] < 0.0001)
                    {
                        cityWeight[i] = 0.0001;
                    }
                    else if (cityWeight[i] > (double.MaxValue / (path_.Length * 100)))
                    {
                        cityWeight[i] = double.MaxValue / (path_.Length * 100);
                    }
                }

                sumCitiesWeight += cityWeight[i];
            }

            double[] transitionProbability = new double[path_.Length];
            for (int i = 0; i < transitionProbability.Length; i++)
            {
                transitionProbability[i] = cityWeight[i] / sumCitiesWeight;
            }
            return transitionProbability;
        }
    }
}
