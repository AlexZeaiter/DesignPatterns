namespace DesignPatterns.SingletonClass
{
    public class ThreadSafetySingletonImp
    {
        ThreadSafetySingletonImp() 
        {
        }
        private static readonly object lockInst = new object();
        private static ThreadSafetySingletonImp? instance;
        private int numberOfSingletonCalls = 0;
        public static ThreadSafetySingletonImp Instance
        {
            get
            {
                lock(lockInst)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafetySingletonImp();
                    }
                    return instance;
                }
            }
        }

        public void callSingleton()
        {
            numberOfSingletonCalls++;
        }
        public int TotalNumberOfCalls
        {
            get
            {
                return numberOfSingletonCalls;
            }
        }
    }
}
