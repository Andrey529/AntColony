using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AntColony
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                int countAnts = Int32.Parse(textBoxcountAnts.Text);
                int countCities = Int32.Parse(textBoxCountCities.Text);
                int alpha = Int32.Parse(textBoxAlpha.Text);
                int beta = Int32.Parse(textBoxBeta.Text);
                double Q = Double.Parse(textBoxQ.Text);
                double rho = Double.Parse(textBoxRho.Text);
                int iterationsCount = Int32.Parse(textBoxIterationsCount.Text);

                if (countCities <= 2 || countAnts < 1 || alpha <= 1 || beta <= 1 || Q <= 0 || rho <= 0 || countCities > 10)
                {
                    throw new ArgumentException("Параметры введены не корректно");
                }

                AntAlgorithm antColony = new AntAlgorithm(countCities, countAnts, alpha, beta, Q, rho, iterationsCount);

                int[][] graph = antColony.GetGraph();
                ShowGraph(graph);
                richTextBoxResAlg.Text = "";
                foreach (var bestLen in antColony.Run())
                {
                    richTextBoxResAlg.Text += "Новая лучшая длина пути: " + bestLen.ToString() + "\n";
                }    
                var BestPath = antColony.GetBest();
                ShowAnswer(BestPath);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowGraph(int[][] graph)
        {
            labelGraph.Text = "   ";
            for (int i = 0; i < graph.Length; i++)
                labelGraph.Text += $"{i + 1} ";
            labelGraph.Text += "\n";
            for (int i = 0; i < graph.Length; i++)
            {
                labelGraph.Text += $"{i + 1}: ";
                for (int j = 0; j < graph[i].Length; j++)
                    labelGraph.Text += $"{graph[i][j]} ";
                labelGraph.Text += "\n";
            }
        }

        private void ShowAnswer((double, int[]) bestTrail)
        {
            richTextBoxResAlg.Text += "Лучшая длина пути = " + bestTrail.Item1.ToString() + "\n" + "Лучший путь:";
            for (int i = 0; i < bestTrail.Item2.Length; i++)
            {
                richTextBoxResAlg.Text += (bestTrail.Item2[i]+1).ToString() + ";";
                if (i > 0 && i % 20 == 0)
                    richTextBoxResAlg.Text += "\n";
            }
            richTextBoxResAlg.Text += (bestTrail.Item2[0] + 1).ToString() + ";";
        }
    }
}
