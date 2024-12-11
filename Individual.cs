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
        public int probabScore;
        public int fitness;
        public int CompareTo(Individual other)
        {
            if(this.fitness < other.fitness) return -1;
            if (this.fitness == other.fitness) return 0; return 1;
        }
    }
}
