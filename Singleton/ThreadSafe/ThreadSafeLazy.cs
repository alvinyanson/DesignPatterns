using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafe
{
    public sealed class ThreadSafeLazy
    {
        //This variable value will be increment by 1 each time the object of the class is created
        private static int Counter = 0;
        
        // The private static instance ensures lazy initialization.
        private static readonly Lazy<ThreadSafeLazy> instance = new Lazy<ThreadSafeLazy>(() => new ThreadSafeLazy());
        // Private constructor to prevent direct instantiation.
        
        private ThreadSafeLazy()
        {
            // Initialization code here
            //Each Time the Constructor is called, increment the Counter value by 1
            Counter++;
            Console.WriteLine("Counter Value " + Counter.ToString());
        }
        
        //The following Static Method is going to return the Singleton Instance
        public static ThreadSafeLazy GetInstance()
        {
            return instance.Value;
        }
        
        //The following method can be accessed from outside of the class by using the Singleton Instance
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
