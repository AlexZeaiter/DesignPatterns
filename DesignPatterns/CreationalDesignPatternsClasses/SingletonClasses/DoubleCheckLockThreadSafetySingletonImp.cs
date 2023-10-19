namespace DesignPatterns.CreationalDesignPatternsClasses.SingletonClasses
{
    public class DoubleCheckLockThreadSafetySingletonImp
    {
        DoubleCheckLockThreadSafetySingletonImp()
        {

        }
        private static readonly object lockInst = new object();
        private static DoubleCheckLockThreadSafetySingletonImp? instance;
        private int numberOfSingletonCalls = 0;
        public static DoubleCheckLockThreadSafetySingletonImp Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockInst)
                    {
                        if (instance == null)
                        {
                            instance = new DoubleCheckLockThreadSafetySingletonImp();
                        }
                    }
                }
                return instance;
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
