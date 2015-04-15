using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_5_3a
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public Dictionary<Int16, Int16> CollectData()
        {
            return new Dictionary<short, short>();
        }

        public short ParseInput(string input)
        {
            short output;
            if (!(short.TryParse(input, out output)))
            {
                return -1;
            }
            return output;
        }
    }
}
