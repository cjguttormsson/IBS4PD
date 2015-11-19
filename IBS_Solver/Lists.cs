using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBS_Solver
{
    /// <summary>
    /// A list of solutions we have explored, created from HashSet. Supports push and pop.
    /// </summary>
    /// <typeparam name="SolutionType"></typeparam>
    class ExploredList<SolutionType> : HashSet<SolutionType>
    {
    }

    /// <summary>
    /// A list of solutions we haven't explored, created from SortedSet. Supports push and pop.
    /// </summary>
    /// <typeparam name="SolutionType"></typeparam>
    class UnexploredList<SolutionType> : SortedSet<SolutionType> //where: ISolution
    {
        public void push(SolutionType s)
        {
            this.Add(s);
        }

        public SolutionType pop()
        {
            SolutionType temp = this.First();
            this.Remove(temp);
            return temp;
        }

        /*public IEnumerable<SolutionType> pop_n_with_lb(int n, int lb)
        {
            for (int i = 0; i < n; ++i)
            {
                SolutionType temp = this.First();
                this.Remove(temp);
                if (temp.lower_bound < )
            }
        }*/

        public IEnumerable<SolutionType> pop_n(int n)
        {
            for (int i = 0; i < n && this.Count > 0; ++i)
            {
                SolutionType temp = this.First();
                this.Remove(temp);
                yield return temp;
            }
            yield break;
        }
    }
}
