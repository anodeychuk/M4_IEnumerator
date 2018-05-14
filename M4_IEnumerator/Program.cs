using System;

namespace M4_IEnumerator
{
    class Program
    {
        /// <summary>
        /// - Create you type
        /// - Add on it array of int/char/string
        /// - Realize interface IEnumerator
        /// - Show all elements of array in console
        /// - Find simple int in array of int
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Array of int
            int length = 15;

            var eaInt = new ElementsArray<int>();

            Random random = new Random();
            for (int i = 0; i < length; i++)
                eaInt.Add(random.Next(1,100));

            // add simple int
            eaInt.Add(5);
            #endregion

            #region Array of char
            length = 5;

            var eaChar = new ElementsArray<char>();

            for (int i = 0; i < length; i++)
                eaChar.Add(Convert.ToChar(random.Next(1, 100)));
            #endregion

            #region Array of string
            length = 11;

            var eaString = new ElementsArray<string>();

            for (int i = 0; i < length; i++)
                eaString.Add( GetRundomString(5) );
            #endregion

            #region Display
            Console.WriteLine("Array of int:");
            Display(eaInt);
            Console.WriteLine("Array of simple int:");
            DisplaySimpleInt(eaInt);
            Console.WriteLine("Array of char:");
            Display(eaChar);
            Console.WriteLine("Array of string:");
            Display(eaString);
            #endregion
        }

        public static void DisplaySimpleInt(ElementsArray<int> arr)
        {
            arr.Reset();
            foreach (int item in arr)
            {
                if(item > 1)
                {
                    bool isDev = false;
                    for (int i = 2; i < item-1; i++)
                    {
                        if (item % i == 0)
                        {
                            isDev = true;
                            break;
                        }
                    }

                    if(!isDev)
                        Console.WriteLine(item);
                }
            }
        }

        static void Display<T>(ElementsArray<T> array)
        {
            array.Reset();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static string GetRundomString(int length)
        {
            string line = "";
            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < length; i++)
            {
                line += Convert.ToChar(random.Next(0, 255)).ToString();
            }

            return line;
        }
    }
}
