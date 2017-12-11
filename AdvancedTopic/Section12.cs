using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopic
{
    public class Section12
    {
    }

    public class DynamicClient
    {
        public void Do()
        {
            object obj = "Mosh";
            //No reflection
            obj.GetHashCode();

            //reflection (ugly)
            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            var xx = methodInfo.Invoke(null, null);

            //dynamic
            dynamic excelObject = "Mosh";
            excelObject.Optimize();

            //changing the type
            dynamic obj1 = "ddd";
            obj1 = 123;

            //Exception runtime
            dynamic obj2 = "ddd";
            obj2++;
        }
    }
}
