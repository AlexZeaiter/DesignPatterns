namespace DesignPatterns.SingletonClass
{
    public sealed class SingletonNoThreadSafeImp
    {
        private SingletonNoThreadSafeImp() { }
        private static SingletonNoThreadSafeImp? instance;
        private int numberOfSingletonCalls = 0;
        public static SingletonNoThreadSafeImp Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new SingletonNoThreadSafeImp();
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
