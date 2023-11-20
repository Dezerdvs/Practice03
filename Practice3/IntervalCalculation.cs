using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class Interval
    {
        protected int Start;
        protected int End;

        public Interval(int Start, int End)
        {
            this.Start = Start;
            this.End = End;
        }
        public double IntervalCalculation()
        {
            double sum = 0;

            for (int i = Start; i <= End; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
