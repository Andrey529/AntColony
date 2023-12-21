using System;
using System.Collections.Generic;

namespace AntColony
{
    public class AntAlgorithm
    {
        private int countCities_;
        private int countAnts_;
        private double bestPathLength_, rho_, Q_;
        private int[] bestPath_;
        private int[][] dists_;
        private Ant[] Ants = null;
        private double[][] pheromones_;
        private static Random random = new Random(0);
        private int iterationsCount_ = 1000;


        public AntAlgorithm(int countCities, int countAnts, int alpha, int beta, double Q, double rho, int iterationsCount)
        {
            Ant.Alpha = alpha;
            Ant.Beta = beta;
            countCities_ = countCities;
            countAnts_ = countAnts;
            rho_ = rho;
            iterationsCount_ = iterationsCount;
            Q_ = Q;
            
            dists_ = GraphMaker.MakeGraphDistances(countCities_);

            Ants = new Ant[countAnts_];
            int i = 0;
            while (i < countAnts_)
            {
                int startCity = random.Next(0, countCities_);
                Ants[i] = new Ant(RandomPath(startCity));
                i++;
            }

            pheromones_ = new double[countCities_][];
            i = 0;
            while (i < pheromones_.Length)
            {
                pheromones_[i] = new double[countCities_];
                for (int j = 0; j < pheromones_[i].Length; j++)
                {
                    pheromones_[i][j] = 0.01;
                }
                i++;
            }
        }

        public IEnumerable<double> Run()
        {
            bestPath_ = SearchBestPath();
            bestPathLength_ = SearchPathLength(bestPath_);

            for (int i = 0; i < iterationsCount_; i++)
            {
                UpdateAnts();
                UpdatePheromones();

                int[] currentBestPath = SearchBestPath();
                double currentBestPathLength = SearchPathLength(currentBestPath);
                if (currentBestPathLength < bestPathLength_)
                {
                    bestPathLength_ = currentBestPathLength;
                    bestPath_ = currentBestPath;
                    yield return bestPathLength_;
                }
            }
        }
        private void UpdateAnts()
        {
            for (int i = 0; i < Ants.Length; i++)
            {
                int start = random.Next(0, countCities_);
                Ants[i].CreatePath(start, pheromones_, dists_);
            }
        }

        public (double, int[]) GetBest() => (bestPathLength_, bestPath_);

        public int[][] GetGraph() => dists_;

        private  int[] RandomPath(int startCity)
        {
            int[] path = new int[countCities_];

            for (int i = 0; i < countCities_; i++)
            {
                path[i] = i;
            }

            for (int i = 0; i < countCities_; i++)
            {
                int r = random.Next(i, countCities_);
                Swap(path, r, i);
            }

            int idx = IndexOfTarget(path, startCity);
            Swap(path, 0, idx);

            return path;
        }

        private  int IndexOfTarget(int[] path, int target)
        {
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == target)
                {
                    return i;
                }
            }

            throw new Exception("Target not found in IndexOfTarget");
        }

        private double SearchPathLength(int[] path)
        {
            double length = 0.0;
            for (int i = 0; i < path.Length - 1; i++)
            {
                length += dists_[path[i]][path[i + 1]];
            }
            length += dists_[path[0]][path[path.Length - 1]];
            return length;
        }

        private int[] SearchBestPath()
        {
            double bestPathLength = Double.MaxValue;
            int indexOfBestPathLength = 0;
            for (int i = 0; i < Ants.Length; i++)
            {
                double length = SearchPathLength(Ants[i].path_);
                if (length < bestPathLength)
                {
                    bestPathLength = length;
                    indexOfBestPathLength = i;
                }
            }
            return Ants[indexOfBestPathLength].path_;
        }

        private void UpdatePheromones()
        {
            for (int i = 0; i < pheromones_.Length; i++)
            {
                for (int j = i + 1; j < pheromones_[i].Length; j++)
                {
                    for (int k = 0; k < Ants.Length; k++)
                    {
                        double length = SearchPathLength(Ants[k].path_);
                        double decrease = (1.0 - rho_) * pheromones_[i][j];
                        double increase = 0.0;
                        if (EdgeInPath(i, j, Ants[k].path_) == true)
                        {
                            increase = (Q_ / length);
                        }

                        pheromones_[i][j] = decrease + increase;

                        NormalizePheromones(i, j);

                        pheromones_[j][i] = pheromones_[i][j];
                    }
                }
            }
        }

        private  bool EdgeInPath(int cityX, int cityY, int[] path)
        {
            int lastIndex = path.Length - 1;
            int idx = IndexOfTarget(path, cityX);

            if (idx == 0 && path[1] == cityY)
            {
                return true;
            }
            else if (idx == 0 && path[lastIndex] == cityY)
            {
                return true;
            }
            else if (idx == 0)
            {
                return false;
            }
            else if (idx == lastIndex && path[lastIndex - 1] == cityY)
            {
                return true;
            }
            else if (idx == lastIndex && path[0] == cityY)
            {
                return true;
            }
            else if (idx == lastIndex)
            {
                return false;
            }
            else if (path[idx - 1] == cityY)
            {
                return true;
            }
            else if (path[idx + 1] == cityY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        private void NormalizePheromones(int i, int j)
        {
            if (pheromones_[i][j] < 0.0001)
            {
                pheromones_[i][j] = 0.0001;
            }
            else if (pheromones_[i][j] > 100000.0)
            {
                pheromones_[i][j] = 100000.0;
            }
        }
    }
}

