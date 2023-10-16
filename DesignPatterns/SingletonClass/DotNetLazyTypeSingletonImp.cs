namespace DesignPatterns.SingletonClass
{
    public class DotNetLazyTypeSingletonImp
    {
        private DotNetLazyTypeSingletonImp() 
        {
        }
        private static readonly Lazy<DotNetLazyTypeSingletonImp> lazy = new Lazy<DotNetLazyTypeSingletonImp>(() => new DotNetLazyTypeSingletonImp());
        private int numberOfSingletonCalls = 0;
        public static DotNetLazyTypeSingletonImp Instance
        {
            get 
            { 
                return lazy.Value; 
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
