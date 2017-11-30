using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopic
{
    public static class Section7
    {
        public static void Do()
        {
            var client = new LamdaDelegateClient();
            client.Main();
        }
        
    }

    public class LamdaDelegateClient
    {
        public int SampleProperty { get; set; } = 3;

        public int SampleFunction()
        {
            return 4;
        }
        public void Main()
        {
            Func<int, int> func = this.Power;
            Console.WriteLine(func(4));

            func = i => i * i;
            Console.WriteLine(func(4));

            func = i => i * SampleProperty * SampleFunction();
            Console.WriteLine(func(4));

            SampleProperty++;
            func = i => SampleProperty;
            Console.WriteLine(func(4));
        }

        public int Power(int x)
        {
            //wrong
            //return x ^ 2;
            return x * x;
        }
    }

    

}
