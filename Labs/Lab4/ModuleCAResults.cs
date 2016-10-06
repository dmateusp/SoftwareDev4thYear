using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class ModuleCAResults
    {
        private const int MAX = 50;                             // max 50 results
        private string[] results = new string[MAX];             // create array
        int next = 0;

        public string Name { get; set; }
        public int Credits { get; set; }
        public string StudentName { get; set; }

        // indexer based on CA
        public string this[int CA]
        {
            get
            {
                int index = CA - 1;                             // CA1 is at index 0 etc.
                if ((index >= 0) && (index < next))             // valid range
                {
                    return results[index];                      // return the result
                }
                else
                {
                    throw new Exception("Invalid CA number");
                }
            }
            set
            {
                // add a result or change an existing result

                int index = CA - 1;
                // no gaps allowed, must overwrite existing result or add at end, and must have space in array
                if ((index >= 0) && (index <= next) && (index < (MAX)))
                {
                    results[index] = value;                     // set the result
                    if (index == next)
                    {
                        next++;                                 // that was a new result
                    }
                }
                else
                {
                    throw new Exception("Invalid CA number");
                }
            }
        }
    }
}
