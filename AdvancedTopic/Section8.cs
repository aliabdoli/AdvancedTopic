using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopic
{
    public static class Section8
    {
        public static void Do()
        {
            var client  = new Section8Client();
            client.Do();
        }
    }

    public class Section8Client
    {
        public void Do()
        {
            var notifier = new Notifier();
            var subscriber = new Subscriber();
            notifier.MyEvent += subscriber.OnRaisedEvent;
            notifier.RaiseEvent();
        }
    }
    public class Notifier
    {
        public delegate void NotifFunction(object sender, EventArgs args);

        public event NotifFunction MyEvent;

        public void RaiseEvent()
        {
            if (MyEvent != null)
                MyEvent.Invoke(this, EventArgs.Empty);
        }
    }

    public class Subscriber
    {
        public void OnRaisedEvent(object sender, EventArgs args)
        {
            args.
            Console.WriteLine("Event raised");
        }
    }
}
