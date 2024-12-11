using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace WinFormsApp1
{
    public  class GeneticAlg
    {
        public List<int> weights;
        public List<int> values;
        public int capacity;

        public int populationSize;
        public int itemsNo;
        public int generationsNo;
        public float selectionPressure;
       

        public List<bool[]> population;
        SortedDictionary<int, bool[]> popScores;
        List<Individual> populationWithScores;
        Dictionary<int, bool[]> bestPopScores; //nieposortowane żeby zobaczyć jak się zmieniało fitness w pokoleniach
        List<bool[]> bestIndividuals;
        List<int> bestFitness;
        public GeneticAlg(List<int> weights, List<int> values, int capacity, int populationSize, int generationsNo, float selectionPressure)
        {
            this.weights = weights;
            this.values = values;
            this.capacity = capacity;
            this.populationSize = populationSize;
            this.generationsNo = generationsNo;
            this.selectionPressure = selectionPressure;
            itemsNo = weights.Count;
            bestPopScores = new Dictionary<int, bool[]>();
            bestFitness = new List<int>();
            bestIndividuals=new List<bool[]>();

            initPop();
        }
        public int main()
        {
            for(int i=0; i< generationsNo; i++)
            {
                GenerateNewPop();
            }
            //return bestPopScores.Last().Key;
            return bestFitness[bestFitness.Count-1];
        }

        //public void Best
        private int Fitness(bool[] individual)
        {
            int currentWeight = 0;
            int value = 0;
            for(int i = 0; i<individual.Length; i++)
            {
                if (individual[i])
                {
                    currentWeight += weights[i];
                    value += values[i];
                }
                if(currentWeight> capacity)
                {
                    return value;
                }
            }
            return value;
        }
        private void CalcPopFitness()
        {
            int[] fitnessScores = new int[population.Count];
            List<bool[]> selected = new List<bool[]>();
            SortedDictionary<int, bool[]> sortedPop = new SortedDictionary<int, bool[]>();
            for (int i = 0;i<population.Count;i++)
            {
                int val = Fitness(population[i]);
                fitnessScores[i] = val;
                try
                {
                    sortedPop.Add(val, population[i]); //na razie pomijam osobniki z tym samym fitness
                }
                catch(Exception e)
                {

                }
                
            }

            popScores = sortedPop; //potencjalny memory leak bez uwolnienia sortedPop?
          
        }
        private List<bool[]> SelectParentsSimple()// wybiera najlepsza polowe
        {
            List<bool[]> s = new List<bool[]>();
            for (int i = 0; i<popScores.Count; i++)
            {
                s.Add( popScores.ElementAt(i).Value);
            }
            return s;
        }
        public int currentGen;
        private void GenerateNewPop()
        {
            CalcPopFitness();
            //bestPopScores.Add(popScores.First().Key, popScores.First().Value);//najlepszy fitness z pokolenia zostaje zapisany
            bestIndividuals.Add(popScores.First().Value);
            bestFitness.Add(popScores.First().Key);
            List<bool[]> selected = SelectParentsSimple();
            Random random = new Random();
            //metoda rangowa
            selectionPressure = 1.2f;//usunac ustawianie na stale
            float[] probabilityScores = new float[selected.Count];
            float scoresSum = 0;
            for (int i =0; i < selected.Count; i++)// (selected.Count/2) polowa wybranych bierze udzial w losowaniu (mozna zmienic)
            {
                //szansa na rozmnazanie
                probabilityScores[i] = (float)(1f / populationSize) * (selectionPressure - (2 * selectionPressure - 2) * (float)(i - 1) / (float)(populationSize - 1));
                scoresSum += probabilityScores[i];
            }
            float maxScore = probabilityScores[0];
            
            
            List<bool[]> newPop = new List<bool[]>(); //to co zwrocimy na koniec jako nowa generacja
            bool[] parent1 = new bool[itemsNo];
            bool[] parent2 = new bool[itemsNo];
            
            //for (int j  = 0; j < populationSize; j++)
            while (newPop.Count < populationSize)
            {
                double rnd = random.NextDouble();//wylosowana wartosc dla prawdopodobienstwa rozmnazania osobnika
                int rndIndividual; 
                bool p1 = false;
                bool p2 = false;
                for (int i = 0; i < 10; i++) 
                {
                    rndIndividual = random.Next(0, populationSize-1);
                    if (rnd - probabilityScores[rndIndividual] <= 0) //czy bierze udzial w rozmnazaniu
                    {
                        parent1 = selected[rndIndividual];
                        p1 = true;
                        break;
                    }
                }

                for (int i = 0; i < 10; i++)
                {
                    rndIndividual = random.Next(0, populationSize-1);
                    if (rnd - probabilityScores[rndIndividual] <= 0) //czy bierze udzial w rozmnazaniu
                    {
                        parent2 = selected[rndIndividual];
                        p2=true;
                        break;
                    }
                }
                if (!p1 || !p2 || Enumerable.SequenceEqual(parent1, parent2)) { continue; }
                bool[] child = CrossoverSimple(parent1, parent2);
                newPop.Add(child);
            }
            //population = new List<bool[]>(newPop);//sprawdzic czy to jest deep copy w c# 
            population.Clear();
            population = newPop;
            currentGen++;
        }
        
        private bool[] CrossoverSimple(bool[] i1, bool[] i2)
        {
            Random random = new Random();
            bool[] child = new bool[i1.Length];
            
            for (int i = 0;i<i1.Length;i++)
            {
                int l= random.Next(0, 2);
                if (l == 0)
                {
                    child[i] = i1[i];
                }
                else
                {
                    child[i] = i2[i];
                }
            }
            return child;
        }
        private void initPop()
        {
            population = new List<bool[]>();
            Random random = new Random();
            for (int i = 0; i<populationSize ; i++)
            {
                bool[] individual = new bool[itemsNo];
                for (int j = 0; j < itemsNo ; j++)
                {
                    int l = random.Next(0, 2);
                    if( l == 0)
                    {
                        individual[j] = false;
                    }
                    else
                    {
                        individual[j] = true;
                    }
                }
                population.Add(individual);
            }
            
        }
    }
    public class Item
    {
        public int weight;
        public int value;
    }
}
