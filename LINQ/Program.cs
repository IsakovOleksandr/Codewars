using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = Count("somehgdasdsssdaa");
        }

        public static Dictionary<char, int> Count(string str)
        {
            return str.GroupBy(i => i).ToDictionary(dict => dict.Key, dict => dict.Count());
        }
    }
}
