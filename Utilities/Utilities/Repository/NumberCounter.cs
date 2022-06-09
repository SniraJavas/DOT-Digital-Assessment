using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Interfaces;

namespace Utilities.Repository
{
    public class NumberCounter : INumberCounter

    {
        int INumberCounter.CountNumbers(string str)
        {
            var num = 0;
            foreach (var s in str) {
                if (int.TryParse(s.ToString(), out int n)) {
                    num++;
                }
            }
            return num;
        }
    }
}
