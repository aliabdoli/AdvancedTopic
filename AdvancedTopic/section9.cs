using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopic
{
    public class section9
    {
    }

    public class ExtensionClient
    {
        public void Main()
        {
            var ss = "asdfa";
            ss.DoAnything();
        }
    }

    public static class AllExtensions
    {
        public static int DoAnything(this string input)
        {
            return 4;
        }

        public static int DoMoreWithTestClass(this TestClass input)
        {
            //Compiler error, no access
            //var privateThings = input.PrivateProp;
            //var protectedThings = input.ProtectedProp;
            return -1;
        }
    }

    public class TestClass
    {
        protected int ProtectedProp { get; set; }
        private int PrivateProp { get; set; }
    }
}
