using OxyPlot.Series;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Legends;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*weights = new List<int>() { 2,13,53,31,2,11,42,32,26,29,15,41,42,99};
            values = new List<int>() { 4, 21, 56, 32, 10, 16, 18, 22, 34, 7, 11, 30, 20, 1000 };*/
            /*weights = new List<int>() { 7,2,1,9,10,5,14};
            values = new List<int>() { 5,4,7,2,8,4,9 };*/
            /*weights = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            values = new List<int>() { 2, 4, 4, 5, 7, 9, 9 };*/
            itemsListView.MouseHover += showItemsNo;
            itemsListView.MouseLeave += hideItemsNo;
            //itemsListView.
            weights = new List<int>();
            values = new List<int>();
            /*for (int i = 0; i < 20; i++)
            {
                addRndItems();

            }*/
        }
        public List<int> weights;
        public List<int> values;

        private void additemBtn_Click(object sender, EventArgs e)
        {
            if (weightTxtBox.Text != "" && valueTxtBox.Text != "")
            {
                weights.Add(Convert.ToInt32(weightTxtBox.Text));
                values.Add(Convert.ToInt32(valueTxtBox.Text));
                itemsListView.Items.Add(weightTxtBox.Text + "   " + valueTxtBox.Text);
                valueTxtBox.Text = "";
                weightTxtBox.Text = "";
            }

        }

        private int knps(int capacity, List<int> wght, List<int> v)
        {
            int n = wght.Count();
            int[,] dp = new int[n + 1, capacity + 1];


            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= capacity; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 0;
                    }
                    else if (wght[i - 1] <= j)
                    {
                        dp[i, j] = Math.Max(v[i - 1] + dp[i - 1, j - wght[i - 1]], dp[i - 1, j]);
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                }

            }
            return dp[n, capacity];
        }

        private void showOptResBtn_Click(object sender, EventArgs e)
        {
            int res = knps(Convert.ToInt32(capacityTxtBox.Text), weights, values);
            optReslabel.Text = res.ToString();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            weights.Clear();
            values.Clear();
            optReslabel.Text = "";
            resultLabel.Text = "Znalezione rozwi¹zanie:";
            itemsListView.Items.Clear();
        }
        private void showItemsNo(object sender, EventArgs e)
        {
            itemsNoLabel.Visible = true;
            itemsNoLabel.Text = "przedmiotów: " + weights.Count;
        }
        private void hideItemsNo(object sender, EventArgs e)
        {
            itemsNoLabel.Visible = false;
        }

        private void geneticBtn_Click(object sender, EventArgs e)
        {
            LowLightItems();
            GeneticAlg alg = new GeneticAlg(weights, values, Convert.ToInt32(capacityTxtBox.Text), Convert.ToInt32(populationTxtBox.Text), Convert.ToInt32(generationsNoTxtBox.Text), (float)Convert.ToDouble(selectionPressureTxtBox.Text), Convert.ToInt32(crossoverRateTxtBox.Text), Convert.ToInt32(mutationRateTxtBox.Text), elitCB.Enabled, Convert.ToInt32(elitismTxtBox.Text));
            int res = alg.main();
            resultLabel.Text = "Znalezione rozwi¹zanie: " + res;
            noGenLabel.Text = "Liczba generacji: " + alg.currentGen;
            Individual bestInd = alg.populationWithScores[0];
            HighlightItems(bestInd);


            var myModel = new PlotModel { Title = "Fitness function" };
            myModel.PlotType = PlotType.Cartesian;

            LineSeries ls = new LineSeries() { };

            for (int i = 0; i < Convert.ToInt32(generationsNoTxtBox.Text); i++)
            {
                ls.Points.Add(new DataPoint(i, alg.bestFitness[i]));
            }

            LineSeries lsAverage = new LineSeries() { };
            for (int i = 0; i < Convert.ToInt32(generationsNoTxtBox.Text); i++)
            {
                lsAverage.Points.Add(new DataPoint(i, alg.averageFitness[i]));
            }
            weightLabel.Text = "Waga: " + bestInd.GetWeight(weights);
            myModel.Legends.Add(new Legend() { LegendTitle = "Best", LegendTitleColor = OxyColors.Green, });
            myModel.Legends.Add(new Legend() { LegendTitle = "Average", LegendPosition = LegendPosition.BottomRight, LegendTitleColor = OxyColors.Orange });
            myModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Minimum = 0,
                Title = "Value"
            });
            myModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                AbsoluteMinimum = 0,
                Title = "Generations"

            });
            myModel.Series.Add(ls);
            myModel.Series.Add(lsAverage);
            plotView1.Model = myModel;

        }
        private void HighlightItems(Individual ind)
        {
            for (int i = 0; i < itemsListView.Items.Count; i++)
            {
                if (ind.representation[i])
                {
                    itemsListView.Items[i].ForeColor = Color.IndianRed;
                }
            }
        }
        private void LowLightItems()
        {
            for (int i = 0; i < itemsListView.Items.Count; i++)
            {
                itemsListView.Items[i].ForeColor = Color.Black;
            }
        }

        private void addRndItemsBtn_Click(object sender, EventArgs e)
        {
            addRndItems();
        }
        private void addRndItems()
        {
            int rndWeight = new Random().Next(2, 20);
            int rndVal = new Random().Next(0, 30);
            weights.Add(rndWeight);
            values.Add(Convert.ToInt32(rndVal));
            itemsListView.Items.Add(rndWeight + "   " + rndVal);
            valueTxtBox.Text = "";
            weightTxtBox.Text = "";



        }
    }
}