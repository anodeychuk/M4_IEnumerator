using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4_IEnumerator
{
    class Generator<T>
    {
        public void Gen<T>()
        {
            var eaInt = new ElementsArray<int>();

            int length = 15;

            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                eaInt.Add(random.Next(1, 100));
                Console.WriteLine(eaInt.Current);
            }
        }
    }
}
