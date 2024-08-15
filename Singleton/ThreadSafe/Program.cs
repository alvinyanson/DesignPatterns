namespace ThreadSafe
{
    class Program
    {
        //Example to Understand Thraed-Safe Problem with Singleton Design Pattern
        //When use in a Multithreaded Environment
        static void Main(string[] args)
        {
            //The following Code will Invoke both methods Parallely using two different Threads
            Parallel.Invoke(
                //Let us Assume PrintTeacherDetails method is Invoked by Thread-1
                () => PrintTeacherDetails(),
                //Let us Assume PrintStudentDetails method is Invoked by Thread-2
                () => PrintStudentDetails()
            );

            Console.ReadLine();
        }
        
        private static void PrintTeacherDetails()
        {
            //Thread-1 Calling the GetInstance() Method of the Singleton class
            ThreadSafe fromTeacher1 = ThreadSafe.GetInstance();
            fromTeacher1.PrintDetails("From Teacher - ThreadSafeLock");

            ThreadSafeDoubleLock fromTeacher2 = ThreadSafeDoubleLock.GetInstance();
            fromTeacher2.PrintDetails("From Teacher - ThreadSafeDoubleLock");

            ThreadSafeLazy fromteacher3 = ThreadSafeLazy.GetInstance();
            fromteacher3.PrintDetails("From Teacher - ThreadSafeLazy");

            ThreadSafeEagerLoading fromTeacher4 = ThreadSafeEagerLoading.GetInstance();
            fromTeacher4.PrintDetails("From Teacher - ThreadSafeEager");
        }
       
        private static void PrintStudentDetails()
        {
            //At the same time, Thread-2 also Calling the GetInstance() Method of the Singleton Class
            ThreadSafe fromStudent1 = ThreadSafe.GetInstance();
            fromStudent1.PrintDetails("From Student - ThreadSafeLock");

            ThreadSafeDoubleLock fromStudent2 = ThreadSafeDoubleLock.GetInstance();
            fromStudent2.PrintDetails("From Student - ThreadSafeDoubleLock");

            ThreadSafeLazy fromStudent3 = ThreadSafeLazy.GetInstance();
            fromStudent3.PrintDetails("From Student - ThreadSafeLazy");

            ThreadSafeEagerLoading fromStudent4 = ThreadSafeEagerLoading.GetInstance();
            fromStudent4.PrintDetails("From Student - ThreadSafeEager");
        }
    }
}