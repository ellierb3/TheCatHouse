using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCatHouse
{
    public static class Extension
    {
        public static List<T> Join<T>(this List<T> femalekittens, List<T> malekittens)
        {
            if (femalekittens == null)
            {
                return malekittens;
            }
            if (malekittens == null)
            {
                return femalekittens;
            }

            return femalekittens.Concat(malekittens).ToList();
        }
    }
    
}

