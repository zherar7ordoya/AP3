using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class UserProcessor
    {
        public static event EventHandler UserProcessorEvent;
        public static void ProcessUser(string name, int age)
        {

        }
    }
    public class UserArgs : EventArgs
    {

    }
}
