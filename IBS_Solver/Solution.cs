using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBS_Solver
{
    public interface ISolution: IComparable<ISolution>
    {
        IEnumerable<ISolution> all_children();
        int lower_bound { get; }
        int upper_bound { get; }
    }

    class Solution
    {
        static int LCM = 1;
        static List<int> periods; //= new List<int> { 1 };

        public List<int> begin_days { get; set; } = Enumerable.Repeat(-1, periods.Count).ToList();
        public List<int> deliveries_per_day { get; set; } = Enumerable.Repeat(0, LCM).ToList();
        public int current_depth { get; set; }

        //Use delegates (reassignable functions) to transparently handle bounds
        public delegate int lb_func();
        public delegate int ub_func();
        lb_func lb_get;  //default will be lb_default
        ub_func ub_get;
        public int lower_bound { get { return lb_get(); } }
        public int upper_bound { get { return ub_get(); } }

        public Solution(Solution other)
        {
            begin_days = new List<int>(other.begin_days);
            deliveries_per_day = new List<int>(other.deliveries_per_day);
            current_depth = other.current_depth;
        }

        IEnumerable<Solution> all_children() ///WHAT IS CURRENT_DEPTH?!?!?!?!?
        {
            for (int i = 0; i < periods[current_depth]; ++i)
            {
                Solution temp = new Solution(this);
                temp.begin_days[current_depth] = i;
                for (int j = i; j < deliveries_per_day.Count; j += periods[current_depth])
                {
                    temp.deliveries_per_day[j]++;
                }
                temp.current_depth++;

                yield return temp;
            }

            yield break;
        }

        //Getters for upper and lower bounds just based on basic rules
        public int lb_default()
        { 
            double base_deliveries = (double)deliveries_per_day.Max();
            foreach (int period in periods.Skip(current_depth + 1)) //CORRECT?!?!?!?!?
            {
                base_deliveries += 1 / period;
            }
            return (int)base_deliveries;
        }

        public int ub_default()
        {
            int base_deliveries = deliveries_per_day.Max();
            base_deliveries += periods.Count - (current_depth + 1);
            return base_deliveries;
        }

        //Dominance rules only based on deliveries_per_day for now
        public override bool Equals(object obj)
        {
            Solution other = obj as Solution;
            return deliveries_per_day.SequenceEqual(other.deliveries_per_day);
        }

        public override int GetHashCode()
        {
            return deliveries_per_day.GetHashCode();
        }

        //For comparing (used in UnexploredList)
        public int CompareTo(Solution other)
        {
            return lower_bound - other.lower_bound;
        }
    }
}
