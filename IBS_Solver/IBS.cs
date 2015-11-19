using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBS_Solver
{
    public class IBS<SolutionType> where SolutionType: ISolution, new()
    {
        private List<ExploredList<SolutionType>> explored;
        private List<UnexploredList<SolutionType>> unexplored;
        private int next_level = 0;
        private int beta; //branching factor
        private int best_lb;
        private int best_ub;

        private int LCM;

        //Constructor
        public IBS(List<int> periods)
        {
            LCM = periods.Aggregate((val1, val2) => val1 * val2 / GCD(val1, val2));
            //BasicSolution.LCM = LCM;

            explored = new List<ExploredList<SolutionType>>(periods.Count);
            unexplored = new List<UnexploredList<SolutionType>>(periods.Count);

            //Start out with a blank/"-1st" solution that precedes lists
            SolutionType empty = new SolutionType();
            //Begin by populating first entry in Unexplored List
            foreach (SolutionType s in empty.all_children())
            {
                unexplored[0].push(s);
            }
        }

        //One iteration
        void iterate()
        {
            for(int i = next_level; i < unexplored.Count; ++i)
            {
                bool processed_something = false;
                foreach (SolutionType s in unexplored[i].pop_n(beta))
                {
                    if (!(s.lower_bound > best_ub)) //guaranteed useless if true
                    {

                    }
                }
            }
        }

        //Used for computing LCM
        private static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
    }
}
