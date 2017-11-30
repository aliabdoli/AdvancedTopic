using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopic
{
    public static class Section6
    {
        public static void Do()
        {
            var client = new Client();
            client.Main();
        }
    }

    public class Client
    {
        //client responsible to configure the funtions should be run
        //the way that processesor handle it is it s own business
        public void Main()
        {
            var processor = new Processor();
            var functions = new Functions();
            Processor.FunctionsDelegates delegates = functions.DoAction1;
            delegates += functions.DoAction2;
            processor.Process(1, delegates);

            ///With default Action/function
            Action<int> actionFunctions = functions.DoAction1;
            actionFunctions += functions.DoAction2;
            processor.Process(1, actionFunctions);
        }
         
    }
    public class Processor
    {
        public delegate void FunctionsDelegates(int id);

        public void Process(int input, FunctionsDelegates handle)
        {
            handle(input);
        }

        public void Process(int input, Action<int> handle)
        {
            handle(input);
        }
    }

    public class Functions
    {
        public void DoAction1(int id)
        {
            Console.WriteLine("DoAction1");
        }

        public void DoAction2(int id)
        {
            Console.WriteLine("DoAction2");
        }

        public void DoAction3(int id)
        {
            Console.WriteLine("DoAction3");
        }
    }
}
