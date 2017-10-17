using System;

namespace puzzle2
{
    class Program
    {
        static Random rand = new Random();

        public static void PrintArrayValues(int[] X)
        {
            foreach(int x in X)
            {
                System.Console.WriteLine(x);
            }
        }

        public static void PrintStringArrayValues(string[] X)
        {
            for(int i = 0; i < X.Length; i++)
            {
                System.Console.WriteLine(X[i]);
            }
        }

        public static int[] RandArray()
        {
            int[] result = new int[10];
            for(int i = 0; i < 10; i++)
            {
                result[i] = rand.Next(5, 26);
            }
            return result;
        }

        public static string TossCoin()
        {
            System.Console.WriteLine("Tossing a coin...");
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int toss = rand.Next(0, 2);
            string result;
            if(toss == 1)
            {
                result = "Heads";
            } else {
                result = "Tails";
            }
            System.Console.WriteLine(result);
            return result;
        }

        public static double TossMultipleCoins(int num) {
            int heads = 0;
            for(int i = 0; i < num; i++)
            {
                if(TossCoin() == "Heads")
                {
                    heads++;
                }
            }
            return (double)heads / (double)num;
        }

        public static string[] Names()
        {
            string[] names = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            int idx = names.Length;
            while(idx > 1)
            {
                idx--;
                int next = rand.Next(0, idx + 1);
                string temp = names[next];
                names[next] = names[idx];
                names[idx] = temp;
            }
            int fiveplus = 0;
            for(int i = 0; i < names.Length; i++){
                if(names[i].Length > 5)
                {
                    fiveplus++;
                }
                System.Console.WriteLine(names[i]);
            }
            string[] result = new string[fiveplus];
            int newcount = 0;
            for(int i = 0; i < names.Length; i++)
            {
                if(names[i].Length > 5)
                {
                    result[newcount] = names[i];
                    newcount++;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // PrintArrayValues(RandArray());
            // TossCoin();
            // double result = TossMultipleCoins(5);
            // System.Console.WriteLine("% Heads: {0}", result.ToString());
            string[] namesResult = Names();
            PrintStringArrayValues(namesResult);
        }
    }
}
