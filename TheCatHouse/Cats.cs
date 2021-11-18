using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCatHouse
{
    public class Cats : Info
    {
        public Cats(string catName, int catAge, string catBreed)
        {
            Name = catName;
            Age = catAge;
            Breed = catBreed;
        }
        public Cats()
        {

        }
    }
}
