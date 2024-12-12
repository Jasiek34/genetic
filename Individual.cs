using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Individual:IComparable<Individual>
    {
        public bool[] representation;
        public float probabScore;
        public int fitness;
         

        public int itemsNo { get 
            {
                return representation.Where(c=>c).Count();
            } }
        public int GetWeight(List<int> weights)
        {
            int weight = 0;
            for (int i = 0; i < weights.Count; i++)
            {
                if (representation[i])
                {
                    weight++;
                }
            }
            return weight;
        }
        public int CompareTo(Individual other)
        {
            if(this.fitness < other.fitness) return 1;
            if (this.fitness == other.fitness) return 0; return -1;
        }
        public void Mutate( int bytesNo)
        {
            int r = new Random().Next(0, representation.Length);
            for (int i = 0; i < bytesNo; i++)
            {
                representation[r] = !representation[r];
            }
        }
    }
}
