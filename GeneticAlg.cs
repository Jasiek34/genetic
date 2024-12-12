﻿using System;
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
        public int currentGen;
        public int crossoverRate;
        public int mutationRate;
        public bool useElitism;
        public int elitismPercent;

        public List<Individual> populationWithScores;
        List<bool[]> bestIndividuals;
        public List<int> bestFitness;
        public List<int> averageFitness;
        
        public GeneticAlg(List<int> weights, List<int> values, int capacity, int populationSize, int generationsNo, float selectionPressure, int crossoverRate, int mutationRate, bool useElitism, int elitismPercent=0)
        {
            this.weights = weights;
            this.values = values;
            this.capacity = capacity;
            this.populationSize = populationSize;
            this.generationsNo = generationsNo;
            this.selectionPressure = selectionPressure;
            this.crossoverRate = crossoverRate;
            itemsNo = weights.Count;
            //bestPopScores = new Dictionary<int, bool[]>();
            bestFitness = new List<int>();
            averageFitness = new List<int>();
            bestIndividuals = new List<bool[]>();
            populationWithScores = new List<Individual>();

            initPop();
            this.mutationRate = mutationRate;
            this.useElitism = useElitism;
            this.elitismPercent = elitismPercent;
        }
        public int main()
        {
            for(int i=0; i< generationsNo; i++)
            {
                GenerateNewPop();
            }
            return bestFitness[bestFitness.Count-1];
        }

        
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
                
            }
            if (currentWeight > capacity)
            {
                return 0;
            }
            return value;
        }
        private void MutatePop()
        {
            foreach(Individual ind in populationWithScores)
            {
                int r = new Random().Next(0, 100);
                if (r < mutationRate)
                {
                    
                    ind.Mutate(1);//mutacja dwoch losowych bitow
                }
            }
        }
        
        private void CalcPopFitness()
        {
            for (int i = 0;i< populationWithScores.Count;i++)
            {
                int val = Fitness(populationWithScores[i].representation);
                populationWithScores[i].fitness = val;
                
            }
            populationWithScores.Sort();
            
        }
        
        private void GenerateNewPop()
        {
            CalcPopFitness();
            bestIndividuals.Add(populationWithScores[0].representation);
            bestFitness.Add(populationWithScores[0].fitness);
            
            int avg = 0;
            int a = 0;
            for(; a< populationWithScores.Count; a++)
            {
                avg+= populationWithScores[a].fitness;
            }
            averageFitness.Add(avg/a);
            
            Random random = new Random();
            //metoda rangowa
            
            
            float scoresSum = 0;
            for (int i =0; i < populationWithScores.Count; i++)
            {
                //szansa na rozmnazanie
                float f = (float)(1f / (float)populationSize) * (selectionPressure - (2 * selectionPressure - 2) * (float)(i - 1) / (float)(populationSize - 1));
                populationWithScores[i].probabScore = f;
                scoresSum += f;
            }
            
            //usuwam polowe najgorszych osobnikow

            populationWithScores.RemoveRange(populationWithScores.Count/2, populationWithScores.Count / 2);
            int currentPopSize = populationWithScores.Count;


            List<Individual> newPop = new List<Individual>(); //to co zwrocimy na koniec jako nowa generacja
            bool[] parent1 = new bool[itemsNo];
            bool[] parent2 = new bool[itemsNo];



            //elityzm 
            if (useElitism)
            {
                int elit = (currentPopSize * elitismPercent) / 100;
                for (int i = 0; i < elit; i++)
                {
                    if (populationWithScores[i].fitness == 0) { break; }
                    Individual ind = new Individual() { representation = populationWithScores[i].representation };
                    newPop.Add(ind);
                }
            }

            while (newPop.Count < populationSize)
            {
                
                double rnd = random.NextDouble();//wylosowana wartosc dla prawdopodobienstwa rozmnazania osobnika
                int rndIndividual; 
                bool p1 = false;
                bool p2 = false;
                for (int i = 0; i < currentPopSize; i++) 
                {
                    rndIndividual = random.Next(0, currentPopSize-1);
                    if (rnd - populationWithScores[rndIndividual].probabScore <= 0) //czy bierze udzial w rozmnazaniu
                    {
                        parent1 = populationWithScores[rndIndividual].representation;
                        p1 = true;
                        break;
                    }
                }

                for (int i = 0; i < currentPopSize; i++)
                {
                    rndIndividual = random.Next(0, currentPopSize-1);
                    if (rnd - populationWithScores[rndIndividual].probabScore <= 0) //czy bierze udzial w rozmnazaniu
                    {
                        parent2 = populationWithScores[rndIndividual].representation;
                        p2=true;
                        break;
                    }
                }
                if (!p1 || !p2) // || Enumerable.SequenceEqual(parent1, parent2)) 
                {
                        continue;
                }
                int k = random.Next(0, 10);
                
                if(k<crossoverRate)
                {
                    bool[] child = CrossoverRandomParentGenes(parent1, parent2);
                    //bool[] child2 = CrossoverTwoPoint(parent1, parent2);
                    newPop.Add(new Individual { representation = child, fitness = 0, probabScore = 0 });
                    //newPop.Add(new Individual { representation = child2, fitness = 0, probabScore = 0 });
                }
                else
                {
                    newPop.Add(new Individual { representation = parent1, fitness = 0, probabScore = 0 });
                    //newPop.Add(new Individual { representation = parent2, fitness = 0, probabScore = 0 });
                }
                
                
            }
            //population = new List<bool[]>(newPop);//sprawdzic czy to jest deep copy w c# 
            currentGen++;
            if (currentGen >= generationsNo)
            {
                return;
            }
            populationWithScores.Clear();
            populationWithScores = newPop;
            MutatePop();
        }
        
        private bool[] CrossoverRandomParentGenes(bool[] i1, bool[] i2)
        {
            Random random = new Random();
            bool[] child = new bool[i1.Length];
            
            for (int i = 0;i<i1.Length;i++)
            {

                int l= random.Next(0, 5);
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
        private bool[] CrossoverTwoPoint(bool[] i1, bool[] i2)
        {
            Random random = new Random();
            int point = random.Next(1, itemsNo-1);//gdzie przecinamy rodzica i1
            int side = random.Next(0,2);//z przodu czy z tylu zostawiamy rodzica i1
            bool[] child = new bool[i1.Length] ;
            child = i1; 
            if(side == 0)
            {
                for (int i = 0; i < point; i++)
                {
                    child[i] = i2[i];
                }
            }
            else
            {
                for (int i = point; i < i1.Length; i++)
                {
                    child[i] = i2[i];
                }
            }
            return child;

        }

        private void initPop()
        {
            populationWithScores = new List<Individual>();
            Random random = new Random();
            for (int i = 0; i<populationSize ; i++)
            {
                bool[] representation = new bool[itemsNo];
                for (int j = 0; j < itemsNo ; j++)
                {
                    int l = random.Next(0, 2);
                    if( l == 0)
                    {
                        representation[j] = false;
                    }
                    else
                    {
                        representation[j] = true;
                    }
                }
                populationWithScores.Add(new Individual { representation = representation, fitness = 0, probabScore = 0 });
               

            }
            
        }
    }
    public class Item
    {
        public int weight;
        public int value;
    }
}
