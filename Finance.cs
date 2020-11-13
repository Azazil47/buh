using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    static class Finance
    {
        static private double balance;
        static public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        static private double costs;
        static public double Costs
        {
            get
            {
                return costs;
            }
            set
            {
                costs = value;
            }
        }
    }
}
